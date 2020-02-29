namespace ITSSSHManagerApp
{
    partial class FormShowInfoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowInfoDetail));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbKeyInfo = new System.Windows.Forms.Label();
            this.lbValueDetail = new System.Windows.Forms.Label();
            this.txtParamValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbKeyInfo
            // 
            this.lbKeyInfo.AutoSize = true;
            this.lbKeyInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbKeyInfo.Location = new System.Drawing.Point(55, 13);
            this.lbKeyInfo.Name = "lbKeyInfo";
            this.lbKeyInfo.Size = new System.Drawing.Size(137, 19);
            this.lbKeyInfo.TabIndex = 1;
            this.lbKeyInfo.Text = "Thông tin tham số: ";
            // 
            // lbValueDetail
            // 
            this.lbValueDetail.AutoSize = true;
            this.lbValueDetail.Location = new System.Drawing.Point(-1, 57);
            this.lbValueDetail.Name = "lbValueDetail";
            this.lbValueDetail.Size = new System.Drawing.Size(90, 15);
            this.lbValueDetail.TabIndex = 2;
            this.lbValueDetail.Text = "Chi tiết tham số";
            // 
            // txtParamValue
            // 
            this.txtParamValue.Location = new System.Drawing.Point(2, 75);
            this.txtParamValue.Multiline = true;
            this.txtParamValue.Name = "txtParamValue";
            this.txtParamValue.ReadOnly = true;
            this.txtParamValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtParamValue.Size = new System.Drawing.Size(391, 142);
            this.txtParamValue.TabIndex = 3;
            // 
            // FormShowInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(394, 219);
            this.Controls.Add(this.txtParamValue);
            this.Controls.Add(this.lbValueDetail);
            this.Controls.Add(this.lbKeyInfo);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormShowInfoDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN CHI TIẾT - ITSHARE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lbKeyInfo;
        private System.Windows.Forms.Label lbValueDetail;
        public System.Windows.Forms.TextBox txtParamValue;
    }
}