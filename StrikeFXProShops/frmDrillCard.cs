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
    public partial class frmDrillCard : Form
    {
        private string m_sConnectionString;
        private int m_iBowlerID = 0;
        private string m_sBowlerName = "";
        private string m_sBowlerHand = "";
        private IDrillCard m_pDrillCard;

        public frmDrillCard()
        {
            InitializeComponent();
        }

        public string ConnectionString
        {
            get { return m_sConnectionString; }
            set { m_sConnectionString = value; }
        }

        public int BowlerID
        {
            get { return m_iBowlerID; }
            set
            {
                m_iBowlerID = value;
                GetBowlerInfo(m_iBowlerID);
                LoadBowlingBalls(m_iBowlerID);
                this.Text = m_sBowlerName;
            }
        }

        private void GetBowlerInfo(int BowlerID)
        {
            using (SqlConnection pConn = new SqlConnection(m_sConnectionString))
            {
                pConn.Open();
                string strSql = "SELECT Bowlers.FirstName, Bowlers.LastName, Hands.Hand FROM Bowlers, Hands WHERE Bowlers.ID = @BowlerID AND Hands.ID = Bowlers.Hand";
                SqlCommand pCommand = new SqlCommand(strSql, pConn);
                // Create a DataAdapter to run the command and fill the DataTable
                pCommand.Parameters.AddWithValue("@BowlerID", BowlerID);
                using (SqlDataReader pReader = pCommand.ExecuteReader())
                {
                    if (pReader.Read())
                    {
                        m_sBowlerName = pReader["FirstName"].ToString() + " " + pReader["LastName"].ToString();
                        m_sBowlerHand = pReader["Hand"].ToString();
                    }
                }
            }
        }

        private void frmDrillCard_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            m_pDrillCard = new DrillCard();
            m_pDrillCard.BowlerID = m_iBowlerID;
            m_pDrillCard.ConnectionString = m_sConnectionString;
            m_pDrillCard.LoadDrillCard();
            m_pDrillCard.LoadVersions(cmbVersion);
            if (cmbVersion.Items.Count > 0)
                cmbVersion.SelectedIndex = 0;
        }

        private void picDrillCard_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.Clear(Color.White);
            PrintBowlerName(e.Graphics);
            PrintModifiedName(e.Graphics);
            DrawFingerHolesAndMoveControls(picDrillCard.Width, picDrillCard.Height, e.Graphics);
        }

        void picDrillCard_Resize(object sender, System.EventArgs e)
        {
            lblVersion.Left = picDrillCard.Width - 176;
            cmbVersion.Left = picDrillCard.Width - 126;
            picDrillCard.Invalidate();
        }

        private void cmbVersion_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_pDrillCard.LoadVersion(cmbVersion.SelectedIndex);
            PopulateFields();
            picDrillCard.Invalidate();
        }

        private void LoadBowlingBalls(int BowlerID)
        {
            using (SqlConnection pConn = new SqlConnection(m_sConnectionString))
            {
                pConn.Open();
                string strSql = "SELECT BowlingBalls.Manufacturer, BowlingBalls.Model, BowlerInventory.Date FROM BowlingBalls, BowlerInventory " +
                                "WHERE BowlerInventory.BowlerID = @BowlerID AND BowlerInventory.BowlingBallID = BowlingBalls.ID ORDER BY Date DESC";
                SqlCommand pCommand = new SqlCommand(strSql, pConn);
                // Create a DataAdapter to run the command and fill the DataTable
                pCommand.Parameters.AddWithValue("@BowlerID", BowlerID);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = pCommand;
                DataTable BowlingBalls = new DataTable();
                da.Fill(BowlingBalls);
                grdBowlingBalls.DataSource = BowlingBalls;
                grdBowlingBalls.AutoResizeColumns();
            }
        }

        private void PrintBowlerName(Graphics pGraphics)
        {
            string msg = String.Format("{0}     Hand:{1}", m_sBowlerName, m_sBowlerHand);
            Font pArial = new Font("Arial", 26);
            float TextWidth = pGraphics.MeasureString(msg, pArial).Width;
            pGraphics.DrawString(msg, pArial, Brushes.Black, (picDrillCard.Width - TextWidth) / 2, (picDrillCard.Height / 8));

        }

        private void PrintModifiedName(Graphics pGraphics)
        {
            string msg = String.Format("Modified By {0} ({1})", m_pDrillCard.ModifiedBy, m_pDrillCard.ModifiedDate.ToShortDateString());
            Font pArial = new Font("Arial", 12);
            SizeF TextSize = pGraphics.MeasureString(msg, pArial);
            pGraphics.DrawString(msg, pArial, Brushes.Black, picDrillCard.Width - TextSize.Width, picDrillCard.Height - TextSize.Height);
        }

        private void DrawFingerHolesAndMoveControls(int Width, int Height, Graphics pGraphics)
        {
            const int CircleDiameter = 75;
            const int CircleRadius = CircleDiameter / 2;
            Font pArial = new Font("Arial", 10);
            int LFingerStartX = (Width / 3) - (CircleDiameter / 2);
            int RFingerStartX = ((Width * 2) / 3) - (CircleDiameter / 2);
            int FingerStartY = (Height / 3) - (CircleDiameter / 2);
            int ThumbStartX = (Width / 2) - (CircleDiameter / 2);
            int ThumbStartY = ((Height * 2) / 3) - (CircleDiameter / 2);

            //Left Finger Hole
            pGraphics.DrawEllipse(Pens.Black, LFingerStartX, FingerStartY, CircleDiameter, CircleDiameter);

            //Right Finger Hole
            pGraphics.DrawEllipse(Pens.Black, RFingerStartX, FingerStartY, CircleDiameter, CircleDiameter);

            //Thumb Hole
            pGraphics.DrawEllipse(Pens.Black, ThumbStartX, ThumbStartY, CircleDiameter, CircleDiameter);

            txtLFingerSize.Location = new Point(LFingerStartX + CircleRadius - (txtLFingerSize.Width / 2), FingerStartY + CircleRadius - (txtLFingerSize.Height / 2));

            txtLFingerForward.Location = new Point(LFingerStartX - txtLFingerForward.Width - 10, FingerStartY);
            DrawArrow(pGraphics, txtLFingerForward.FractionValue, txtLFingerForward.Left - 15, txtLFingerForward.Top, txtLFingerForward.Left - 15, txtLFingerForward.Top + txtLFingerForward.Height);

            txtLFingerLateral.Location = new Point(LFingerStartX - txtLFingerLateral.Width - 10, FingerStartY + txtLFingerForward.Height + 10);
            DrawArrow(pGraphics, txtLFingerLateral.FractionValue, txtLFingerLateral.Left - 25, txtLFingerLateral.Top + (txtLFingerLateral.Height / 2), txtLFingerLateral.Left - 5, txtLFingerLateral.Top + (txtLFingerLateral.Height / 2));
            
            txtBridge.Location = new Point(((LFingerStartX + CircleDiameter + RFingerStartX) / 2) - txtBridge.Width / 2, FingerStartY);

            txtRFingerSize.Location = new Point(RFingerStartX + CircleRadius - (txtRFingerSize.Width / 2), FingerStartY + CircleRadius - (txtRFingerSize.Height / 2));

            txtRFingerForward.Location = new Point(RFingerStartX + CircleDiameter + 10, FingerStartY);
            DrawArrow(pGraphics, txtRFingerForward.FractionValue, txtRFingerForward.Left + txtRFingerForward.Width + 15, txtRFingerForward.Top, txtRFingerForward.Left + txtRFingerForward.Width + 15, txtRFingerForward.Top + txtRFingerForward.Height);

            txtRFingerLateral.Location = new Point(RFingerStartX + CircleDiameter + 10, FingerStartY + txtRFingerForward.Height + 10);
            DrawArrow(pGraphics, txtRFingerLateral.FractionValue, txtRFingerLateral.Left + txtRFingerLateral.Width + 5, txtRFingerLateral.Top + (txtRFingerLateral.Height / 2), txtRFingerLateral.Left + txtRFingerLateral.Width + 25, txtRFingerLateral.Top + (txtRFingerLateral.Height / 2));

            txtTHoleSize.Location = new Point(ThumbStartX + CircleRadius - (txtTHoleSize.Width / 2), ThumbStartY + CircleRadius - (txtTHoleSize.Height / 2));

            txtTForward.Location = new Point(ThumbStartX + CircleDiameter + 10, ThumbStartY);
            DrawArrow(pGraphics, txtTForward.FractionValue, txtTForward.Left + txtTForward.Width + 15, txtTForward.Top + txtTForward.Height, txtTForward.Left + txtTForward.Width + 15, txtTForward.Top);

            txtTLateral.Location = new Point(ThumbStartX + CircleDiameter + 10, ThumbStartY + txtTForward.Height + 10);
            DrawArrow(pGraphics, txtTLateral.FractionValue, txtTLateral.Left + txtTLateral.Width + 5, txtTLateral.Top + (txtTLateral.Height / 2), txtTLateral.Left + txtTLateral.Width + 25, txtTLateral.Top + (txtTLateral.Height / 2));

            txtLSpan.Location = new Point((LFingerStartX + ThumbStartX + CircleDiameter - txtLSpan.Width) / 2, (FingerStartY + ThumbStartY + CircleDiameter - txtLSpan.Height) / 2);
            txtRSpan.Location = new Point((RFingerStartX + ThumbStartX + CircleDiameter - txtRSpan.Width) / 2, (FingerStartY + ThumbStartY + CircleDiameter - txtRSpan.Height) / 2);

        }

        private void DrawArrow(Graphics pGraphics, Fraction fraction, int X1, int Y1, int X2, int Y2)
        {
            using (Pen p = new Pen(Brushes.Black, 4f))
            {
                //Specify the EndCap, because we're drawing a right-facing arrow
                if (fraction > 0)
                    p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                else if (fraction < 0)
                    p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                else
                {
                    p.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                    p.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                }

                //Draw the arrow
                pGraphics.DrawLine(p, X1, Y1, X2, Y2);
            }
        }

        private void txtMeasurements_TextChanged(object sender, System.EventArgs e)
        {
            picDrillCard.Invalidate();
        }

        private void PopulateFields()
        {
            txtLFingerSize.FractionValue = m_pDrillCard.LHoleSize;
            txtLFingerForward.FractionValue = m_pDrillCard.LForwardPitch;
            txtLFingerLateral.FractionValue = m_pDrillCard.LLateralPitch;

            txtRFingerSize.FractionValue = m_pDrillCard.RHoleSize;
            txtRFingerForward.FractionValue = m_pDrillCard.RForwardPitch;
            txtRFingerLateral.FractionValue = m_pDrillCard.RLateralPitch;

            txtTHoleSize.FractionValue = m_pDrillCard.THoleSize;
            txtTForward.FractionValue = m_pDrillCard.TForwardPitch;
            txtTLateral.FractionValue = m_pDrillCard.TLateralPitch;

            txtBridge.FractionValue = m_pDrillCard.Bridge;
            txtLSpan.FractionValue = m_pDrillCard.LSpan;
            txtRSpan.FractionValue = m_pDrillCard.RSpan;
        }

        private void txtLFingerForward_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
