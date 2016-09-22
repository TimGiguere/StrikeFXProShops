using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Strike_FX_Pro_Shops
{
    public partial class frmCustomers : Form
    {
        private DataTable m_pCustomers = null;
        private const int IDColumn = 0;
        private const int FirstNameColumn = 1;
        private const int LastNameColumn = 2;
        private const int HandColumn = 3;
        private const int DrillCardColumn = 4;
        private const int InfoColumn = 5;

        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            RefreshDataTable();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmBowlerInformation f = new frmBowlerInformation();
            f.BowlerID = -1;
            if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                RefreshDataTable();
            }
        }

        private void UpdateGrid()
        {
            if (txtSearchName.Text.Trim() != "")
                grdCustomers.DataSource = m_pCustomers.Select(String.Format("FirstName LIKE '%{0}%' OR LastName LIKE '%{0}%'", txtSearchName.Text)).CopyToDataTable();
            else
                grdCustomers.DataSource = m_pCustomers;
        }

        private void RefreshDataTable()
        {
            try
            {
                string strConn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProShopData;Data Source=localhost\SQLEXPRESS";
                using (SqlConnection pConnection = new SqlConnection(strConn))
                {
                    string strSql = "SELECT Bowlers.ID, Bowlers.FirstName, Bowlers.LastName, Hands.Hand FROM Bowlers, Hands WHERE Bowlers.Hand = Hands.ID";
                    SqlCommand pCommand = new SqlCommand(strSql, pConnection);
                    pCommand.CommandType = CommandType.Text;

                    // Create a DataAdapter to run the command and fill the DataTable
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = pCommand;
                    m_pCustomers = new DataTable();
                    da.Fill(m_pCustomers);

                    UpdateGrid();

                    RefreshColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void RefreshColumns()
        {
            grdCustomers.Columns[IDColumn].Visible = false;
            grdCustomers.Columns[FirstNameColumn].Width = (int)(grdCustomers.Width * .33);
            grdCustomers.Columns[FirstNameColumn].HeaderText = "First Name";
            grdCustomers.Columns[FirstNameColumn].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdCustomers.Columns[LastNameColumn].Width = (int)(grdCustomers.Width * .39);
            grdCustomers.Columns[LastNameColumn].HeaderText = "Last Name";
            grdCustomers.Columns[LastNameColumn].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdCustomers.Columns[HandColumn].Width = (int)(grdCustomers.Width * .11);
            grdCustomers.Columns[HandColumn].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdCustomers.Columns[HandColumn].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DataGridViewImageButtonDrillCardColumn clmDrillCard = new DataGridViewImageButtonDrillCardColumn();
            grdCustomers.Columns.Add(clmDrillCard);
            DataGridViewImageButtonInfoCardColumn clmInfoCard = new DataGridViewImageButtonInfoCardColumn();
            grdCustomers.Columns.Add(clmInfoCard);

        }

        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDrillCard f = new frmDrillCard();
            string strConn = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=ProShopData;Data Source=localhost\SQLEXPRESS";
            f.ConnectionString = strConn;
            f.BowlerID = (int)grdCustomers[2, e.RowIndex].Value;
            f.ShowDialog();
        }

        private void grdCustomers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }

    public class DataGridViewImageButtonDrillCardCell : DataGridViewImageButtonCell
    {
        public override void LoadImages()
        {
            // Load the Normal, Hot and Disabled "Delete" images here.
            // Load them from a resource file, local file, hex string, etc.
            _buttonImageHot = Properties.Resources.dialog_information_4;
            _buttonImageNormal = Properties.Resources.dialog_information_4;
            _buttonImageDisabled = Properties.Resources.dialog_information_4;
        }
    }

    public class DataGridViewImageButtonDrillCardColumn : DataGridViewButtonColumn
    {
        public DataGridViewImageButtonDrillCardColumn()
        {
            this.CellTemplate = new DataGridViewImageButtonDrillCardCell();
            this.Width = 22;
            this.Resizable = DataGridViewTriState.False;
        }
    }

    public class DataGridViewImageButtonInfoCardCell : DataGridViewImageButtonCell
    {
        public override void LoadImages()
        {
            // Load the Normal, Hot and Disabled "Delete" images here.
            // Load them from a resource file, local file, hex string, etc.
            _buttonImageHot = Properties.Resources.measure;
            _buttonImageNormal = Properties.Resources.measure;
            _buttonImageDisabled = Properties.Resources.measure;
        }
    }

    public class DataGridViewImageButtonInfoCardColumn : DataGridViewButtonColumn
    {
        public DataGridViewImageButtonInfoCardColumn()
        {
            this.CellTemplate = new DataGridViewImageButtonInfoCardCell();
            this.Width = 20;
            this.Resizable = DataGridViewTriState.False;
        }
    }
}
