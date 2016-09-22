namespace Strike_FX_Pro_Shops
{
    partial class frmDrillCard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDrillCard));
            this.grdBowlingBalls = new System.Windows.Forms.DataGridView();
            this.picDrillCard = new System.Windows.Forms.PictureBox();
            this.cmbVersion = new System.Windows.Forms.ComboBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtLSpan = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtRSpan = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtTLateral = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtTForward = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtTHoleSize = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtLFingerLateral = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtRFingerLateral = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtRFingerForward = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtRFingerSize = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtLFingerForward = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtLFingerSize = new Strike_FX_Pro_Shops.NumericTextBox();
            this.txtBridge = new Strike_FX_Pro_Shops.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdBowlingBalls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrillCard)).BeginInit();
            this.SuspendLayout();
            // 
            // grdBowlingBalls
            // 
            this.grdBowlingBalls.AllowUserToAddRows = false;
            this.grdBowlingBalls.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdBowlingBalls.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdBowlingBalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBowlingBalls.Dock = System.Windows.Forms.DockStyle.Right;
            this.grdBowlingBalls.Location = new System.Drawing.Point(520, 0);
            this.grdBowlingBalls.Name = "grdBowlingBalls";
            this.grdBowlingBalls.RowHeadersVisible = false;
            this.grdBowlingBalls.Size = new System.Drawing.Size(336, 574);
            this.grdBowlingBalls.TabIndex = 0;
            // 
            // picDrillCard
            // 
            this.picDrillCard.BackColor = System.Drawing.Color.White;
            this.picDrillCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picDrillCard.Location = new System.Drawing.Point(0, 0);
            this.picDrillCard.Name = "picDrillCard";
            this.picDrillCard.Size = new System.Drawing.Size(520, 574);
            this.picDrillCard.TabIndex = 1;
            this.picDrillCard.TabStop = false;
            this.picDrillCard.Paint += new System.Windows.Forms.PaintEventHandler(this.picDrillCard_Paint);
            this.picDrillCard.Resize += new System.EventHandler(this.picDrillCard_Resize);
            // 
            // cmbVersion
            // 
            this.cmbVersion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVersion.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVersion.FormattingEnabled = true;
            this.cmbVersion.Location = new System.Drawing.Point(341, 9);
            this.cmbVersion.Name = "cmbVersion";
            this.cmbVersion.Size = new System.Drawing.Size(116, 23);
            this.cmbVersion.TabIndex = 2;
            this.cmbVersion.SelectedIndexChanged += new System.EventHandler(this.cmbVersion_SelectedIndexChanged);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.White;
            this.lblVersion.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(291, 13);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(38, 15);
            this.lblVersion.TabIndex = 3;
            this.lblVersion.Text = "Version";
            // 
            // txtLSpan
            // 
            this.txtLSpan.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLSpan.Location = new System.Drawing.Point(195, 177);
            this.txtLSpan.Name = "txtLSpan";
            this.txtLSpan.Size = new System.Drawing.Size(54, 20);
            this.txtLSpan.TabIndex = 16;
            this.txtLSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtRSpan
            // 
            this.txtRSpan.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSpan.Location = new System.Drawing.Point(277, 153);
            this.txtRSpan.Name = "txtRSpan";
            this.txtRSpan.Size = new System.Drawing.Size(54, 20);
            this.txtRSpan.TabIndex = 15;
            this.txtRSpan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTLateral
            // 
            this.txtTLateral.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTLateral.Location = new System.Drawing.Point(171, 333);
            this.txtTLateral.Name = "txtTLateral";
            this.txtTLateral.Size = new System.Drawing.Size(54, 20);
            this.txtTLateral.TabIndex = 14;
            this.txtTLateral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTLateral.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            // 
            // txtTForward
            // 
            this.txtTForward.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTForward.Location = new System.Drawing.Point(141, 352);
            this.txtTForward.Name = "txtTForward";
            this.txtTForward.Size = new System.Drawing.Size(54, 20);
            this.txtTForward.TabIndex = 13;
            this.txtTForward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTForward.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            // 
            // txtTHoleSize
            // 
            this.txtTHoleSize.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTHoleSize.Location = new System.Drawing.Point(139, 307);
            this.txtTHoleSize.Name = "txtTHoleSize";
            this.txtTHoleSize.Size = new System.Drawing.Size(54, 20);
            this.txtTHoleSize.TabIndex = 12;
            this.txtTHoleSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLFingerLateral
            // 
            this.txtLFingerLateral.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLFingerLateral.Location = new System.Drawing.Point(214, 231);
            this.txtLFingerLateral.Name = "txtLFingerLateral";
            this.txtLFingerLateral.Size = new System.Drawing.Size(54, 20);
            this.txtLFingerLateral.TabIndex = 11;
            this.txtLFingerLateral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLFingerLateral.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            // 
            // txtRFingerLateral
            // 
            this.txtRFingerLateral.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFingerLateral.Location = new System.Drawing.Point(296, 207);
            this.txtRFingerLateral.Name = "txtRFingerLateral";
            this.txtRFingerLateral.Size = new System.Drawing.Size(54, 20);
            this.txtRFingerLateral.TabIndex = 10;
            this.txtRFingerLateral.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRFingerLateral.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            // 
            // txtRFingerForward
            // 
            this.txtRFingerForward.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFingerForward.Location = new System.Drawing.Point(364, 356);
            this.txtRFingerForward.Name = "txtRFingerForward";
            this.txtRFingerForward.Size = new System.Drawing.Size(54, 20);
            this.txtRFingerForward.TabIndex = 9;
            this.txtRFingerForward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRFingerForward.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            // 
            // txtRFingerSize
            // 
            this.txtRFingerSize.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRFingerSize.Location = new System.Drawing.Point(347, 303);
            this.txtRFingerSize.Name = "txtRFingerSize";
            this.txtRFingerSize.Size = new System.Drawing.Size(54, 20);
            this.txtRFingerSize.TabIndex = 8;
            this.txtRFingerSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLFingerForward
            // 
            this.txtLFingerForward.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLFingerForward.Location = new System.Drawing.Point(317, 322);
            this.txtLFingerForward.Name = "txtLFingerForward";
            this.txtLFingerForward.Size = new System.Drawing.Size(54, 20);
            this.txtLFingerForward.TabIndex = 6;
            this.txtLFingerForward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLFingerForward.TextChanged += new System.EventHandler(this.txtMeasurements_TextChanged);
            // 
            // txtLFingerSize
            // 
            this.txtLFingerSize.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLFingerSize.Location = new System.Drawing.Point(315, 277);
            this.txtLFingerSize.Name = "txtLFingerSize";
            this.txtLFingerSize.Size = new System.Drawing.Size(54, 20);
            this.txtLFingerSize.TabIndex = 5;
            this.txtLFingerSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBridge
            // 
            this.txtBridge.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBridge.Location = new System.Drawing.Point(49, 140);
            this.txtBridge.Name = "txtBridge";
            this.txtBridge.Size = new System.Drawing.Size(54, 20);
            this.txtBridge.TabIndex = 4;
            this.txtBridge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmDrillCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 574);
            this.Controls.Add(this.txtLSpan);
            this.Controls.Add(this.txtRSpan);
            this.Controls.Add(this.txtTLateral);
            this.Controls.Add(this.txtTForward);
            this.Controls.Add(this.txtTHoleSize);
            this.Controls.Add(this.txtLFingerLateral);
            this.Controls.Add(this.txtRFingerLateral);
            this.Controls.Add(this.txtRFingerForward);
            this.Controls.Add(this.txtRFingerSize);
            this.Controls.Add(this.txtLFingerForward);
            this.Controls.Add(this.txtLFingerSize);
            this.Controls.Add(this.txtBridge);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.cmbVersion);
            this.Controls.Add(this.picDrillCard);
            this.Controls.Add(this.grdBowlingBalls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDrillCard";
            this.Load += new System.EventHandler(this.frmDrillCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBowlingBalls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDrillCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBowlingBalls;
        private System.Windows.Forms.PictureBox picDrillCard;
        private System.Windows.Forms.ComboBox cmbVersion;
        private System.Windows.Forms.Label lblVersion;
        private NumericTextBox txtBridge;
        private NumericTextBox txtLFingerSize;
        private NumericTextBox txtLFingerForward;
        private NumericTextBox txtRFingerLateral;
        private NumericTextBox txtRFingerForward;
        private NumericTextBox txtRFingerSize;
        private NumericTextBox txtLFingerLateral;
        private NumericTextBox txtTLateral;
        private NumericTextBox txtTForward;
        private NumericTextBox txtTHoleSize;
        private NumericTextBox txtLSpan;
        private NumericTextBox txtRSpan;
    }
}