using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Strike_FX_Pro_Shops
{
    class DrillCard : IDrillCard
    {
        private int m_iBowlerID = 0;
        private string m_sConnectionString = "";
        private Fraction m_pLHoleSize = new Fraction();
        private Fraction m_pLLateralPitch = new Fraction();
        private Fraction m_pLForwardPitch = new Fraction();
        private Fraction m_pRHoleSize = new Fraction();
        private Fraction m_pRLateralPitch = new Fraction();
        private Fraction m_pRForwardPitch = new Fraction();
        private Fraction m_pTHoleSize = new Fraction();
        private Fraction m_pTOffset = new Fraction();
        private Fraction m_pTLateralPitch = new Fraction();
        private Fraction m_pTForwardPitch = new Fraction();
        private Fraction m_pTSlugSize = new Fraction();
        private Fraction m_pBridge = new Fraction();
        private Fraction m_pLSpan = new Fraction();
        private Fraction m_pRSpan = new Fraction();
        private string m_sModifiedBy;
        private DateTime m_dteModifiedDate;

        private DataTable m_pDrillCards;

        public int BowlerID
        {
            get { return m_iBowlerID; }
            set { m_iBowlerID = value; }
        }

        public string ConnectionString
        {
            get { return m_sConnectionString; }
            set { m_sConnectionString = value; }
        }

        public Fraction LHoleSize
        {
            get { return m_pLHoleSize; }
            set { m_pLHoleSize = value; }
        }

        public Fraction LLateralPitch
        {
            get { return m_pLLateralPitch; }
            set { m_pLLateralPitch = value; }
        }

        public Fraction LForwardPitch
        {
            get { return m_pLForwardPitch; }
            set { m_pLForwardPitch = value; }
        }

        public Fraction RHoleSize
        {
            get { return m_pRHoleSize; }
            set { m_pRHoleSize = value; }
        }

        public Fraction RLateralPitch
        {
            get { return m_pRLateralPitch; }
            set { m_pRLateralPitch = value; }
        }

        public Fraction RForwardPitch
        {
            get { return m_pRForwardPitch; }
            set { m_pRForwardPitch = value; }
        }

        public Fraction THoleSize
        {
            get { return m_pTHoleSize; }
            set { m_pTHoleSize = value; }
        }

        public Fraction TOffset
        {
            get { return m_pTOffset; }
            set { m_pTOffset = value; }
        }

        public Fraction TLateralPitch
        {
            get { return m_pTLateralPitch; }
            set { m_pTLateralPitch = value; }
        }

        public Fraction TForwardPitch
        {
            get { return m_pTForwardPitch; }
            set { m_pTForwardPitch = value; }
        }

        public Fraction TSlugSize
        {
            get { return m_pTSlugSize; }
            set { m_pTSlugSize = value; }
        }

        public Fraction Bridge
        {
            get { return m_pBridge; }
            set { m_pBridge = value; }
        }

        public Fraction LSpan
        {
            get { return m_pLSpan; }
            set { m_pLSpan = value; }
        }

        public Fraction RSpan
        {
            get { return m_pRSpan; }
            set { m_pRSpan = value; }
        }

        public string ModifiedBy
        {
            get { return m_sModifiedBy; }
            set { m_sModifiedBy = value; }
        }

        public DateTime ModifiedDate
        {
            get { return m_dteModifiedDate; }
            set { m_dteModifiedDate = value; }
        }

        public void LoadDrillCard()
        {
            if (m_iBowlerID == 0)
                return;

            try
            {

                using (SqlConnection pConn = new SqlConnection(m_sConnectionString))
                {
                    pConn.Open();
                    string strSql = "SELECT * FROM DrillCards WHERE BowlerID = @BowlerID ORDER BY Version DESC";
                    SqlCommand pCommand = new SqlCommand(strSql, pConn);
                    // Create a DataAdapter to run the command and fill the DataTable
                    pCommand.Parameters.AddWithValue("@BowlerID", m_iBowlerID);
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = pCommand;
                    m_pDrillCards = new DataTable();
                    da.Fill(m_pDrillCards);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadVersions(ComboBox Destination)
        {
            Destination.Items.Clear();

            foreach (DataRow pRow in m_pDrillCards.Rows)
            {
                DateTime pDate = (DateTime)pRow["DateModified"];
                Destination.Items.Add(String.Format("{0}: {1}", pRow["Version"], pDate.ToShortDateString()));
            }
        }

        public void LoadVersion(int VersionIndex)
        {
            DataRow pRow = m_pDrillCards.Rows[VersionIndex];
            m_pLHoleSize = pRow["LHoleSize"].ToString();
            m_pLLateralPitch = pRow["LLateralPitch"].ToString();
            m_pLForwardPitch = pRow["LForwardPitch"].ToString();
            m_pRHoleSize = pRow["RHoleSize"].ToString();
            m_pRLateralPitch = pRow["RLateralPitch"].ToString();
            m_pRForwardPitch = pRow["RForwardPitch"].ToString();
            m_pTHoleSize = pRow["THoleSize"].ToString();
            m_pTOffset = pRow["TOffset"].ToString();
            m_pTLateralPitch = pRow["TLateralPitch"].ToString();
            m_pTForwardPitch = pRow["TForwardPitch"].ToString();
            m_pTSlugSize = pRow["TSlugSize"].ToString();
            m_pBridge = pRow["Bridge"].ToString();
            m_pLSpan = pRow["LSpan"].ToString();
            m_pRSpan = pRow["RSpan"].ToString();
            m_sModifiedBy = GetEmployee(Convert.ToInt32(pRow["ModifiedBy"].ToString()));
            m_dteModifiedDate = Convert.ToDateTime(pRow["DateModified"].ToString());
        }

        private string GetEmployee(int EmployeeID)
        {
            string sResult = "";
            using (SqlConnection pConn = new SqlConnection(m_sConnectionString))
            {
                pConn.Open();
                string strSql = "SELECT FirstName + ' ' + LastName AS FullName FROM Employees WHERE ID = @ID";
                SqlCommand pCommand = new SqlCommand(strSql, pConn);
                // Create a DataAdapter to run the command and fill the DataTable
                pCommand.Parameters.AddWithValue("@ID", EmployeeID);
                using (SqlDataReader pReader = pCommand.ExecuteReader())
                {
                    if (pReader.Read())
                        sResult = pReader["FullName"].ToString();
                }
            }

            return sResult;
        }
    }
}
