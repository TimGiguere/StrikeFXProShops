using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Strike_FX_Pro_Shops
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers f = new frmCustomers();
            f.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }
    }
}
