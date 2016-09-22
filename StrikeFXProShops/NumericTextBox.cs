using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strike_FX_Pro_Shops
{
    public partial class NumericTextBox : TextBox
    {
        private Fraction m_pFraction;

        public NumericTextBox()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(NumericTextBox_KeyPress);
            this.KeyDown += new KeyEventHandler(NumericTextBox_KeyDown);
        }

        void NumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue == (int)Keys.Left) || (e.KeyValue == (int)Keys.Down))
            {
                FractionValue -= "1/64";
            }
            else if ((e.KeyValue == (int)Keys.Right) || (e.KeyValue == (int)Keys.Up))
            {
                FractionValue += "1/64";
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Fraction FractionValue
        {
            get { return m_pFraction; }
            set
            {
                m_pFraction = value;
                this.Text = m_pFraction.ToString();
            }
        }

        void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsDigit(e.KeyChar)) || (e.KeyChar == ' ') || (e.KeyChar == '/'))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
