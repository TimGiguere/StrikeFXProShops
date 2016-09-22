using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strike_FX_Pro_Shops
{
    public partial class frmBowlerInformation : Form
    {
        private int m_iBowlerID = 0;
        
        public frmBowlerInformation()
        {
            InitializeComponent();
        }

        public int BowlerID
        {
            get { return m_iBowlerID; }
            set { m_iBowlerID = value; }
        }

        private void frmBowlerInformation_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
