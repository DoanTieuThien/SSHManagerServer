namespace ITSSSHManagerApp
{
    partial class FormApplicationInfoDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApplicationInfoDetail));
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPidApplication = new System.Windows.Forms.Label();
            this.lbCpuInfo = new System.Windows.Forms.Label();
            this.lbRamInfo = new System.Windows.Forms.Label();
            this.lbVSZInfo = new System.Windows.Forms.Label();
            this.lbStartInfo = new System.Windows.Forms.Label();
            this.lbStatInfo = new System.Windows.Forms.Label();
            this.lbRssInfo = new System.Windows.Forms.Label();
            this.lbTTYInfo = new System.Windows.Forms.Label();
            this.lbTimeInfo = new System.Windows.Forms.Label();
            this.lbCommand = new System.Windows.Forms.Label();
            this.txtUserValue = new System.Windows.Forms.TextBox();
            this.txtPIDValue = new System.Windows.Forms.TextBox();
            this.txtCPUValue = new System.Windows.Forms.TextBox();
            this.txtMEMValue = new System.Windows.Forms.TextBox();
            this.txtVSZValue = new System.Windows.Forms.TextBox();
            this.txtRSSValue = new System.Windows.Forms.TextBox();
            this.txtTTYValue = new System.Windows.Forms.TextBox();
            this.txtSTATValue = new System.Windows.Forms.TextBox();
            this.txtSTARTValue = new System.Windows.Forms.TextBox();
            this.txtTIMEValue = new System.Windows.Forms.TextBox();
            this.txtCOMMANDValue = new System.Windows.Forms.TextBox();
            this.lbPortRunning = new System.Windows.Forms.Label();
            this.txtPortRunning = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(10, 46);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(169, 15);
            this.lbUser.TabIndex = 0;
            this.lbUser.Text = "Người chạy ứng dụng (USER):";
            // 
            // lbPidApplication
            // 
            this.lbPidApplication.AutoSize = true;
            this.lbPidApplication.Location = new System.Drawing.Point(12, 74);
            this.lbPidApplication.Name = "lbPidApplication";
            this.lbPidApplication.Size = new System.Drawing.Size(85, 15);
            this.lbPidApplication.TabIndex = 1;
            this.lbPidApplication.Text = "PID ứng dụng:";
            // 
            // lbCpuInfo
            // 
            this.lbCpuInfo.AutoSize = true;
            this.lbCpuInfo.Location = new System.Drawing.Point(10, 102);
            this.lbCpuInfo.Name = "lbCpuInfo";
            this.lbCpuInfo.Size = new System.Drawing.Size(89, 15);
            this.lbCpuInfo.TabIndex = 2;
            this.lbCpuInfo.Text = "Chiếm CPU(%):";
            // 
            // lbRamInfo
            // 
            this.lbRamInfo.AutoSize = true;
            this.lbRamInfo.Location = new System.Drawing.Point(12, 130);
            this.lbRamInfo.Name = "lbRamInfo";
            this.lbRamInfo.Size = new System.Drawing.Size(122, 15);
            this.lbRamInfo.TabIndex = 3;
            this.lbRamInfo.Text = "Chiếm Ram (%MEM):";
            // 
            // lbVSZInfo
            // 
            this.lbVSZInfo.AutoSize = true;
            this.lbVSZInfo.Location = new System.Drawing.Point(10, 158);
            this.lbVSZInfo.Name = "lbVSZInfo";
            this.lbVSZInfo.Size = new System.Drawing.Size(154, 15);
            this.lbVSZInfo.TabIndex = 4;
            this.lbVSZInfo.Text = "Thông tin bộ nhớ ảo (VSZ):";
            // 
            // lbStartInfo
            // 
            this.lbStartInfo.AutoSize = true;
            this.lbStartInfo.Location = new System.Drawing.Point(10, 270);
            this.lbStartInfo.Name = "lbStartInfo";
            this.lbStartInfo.Size = new System.Drawing.Size(113, 15);
            this.lbStartInfo.TabIndex = 5;
            this.lbStartInfo.Text = "Năm chạy (START):";
            // 
            // lbStatInfo
            // 
            this.lbStatInfo.AutoSize = true;
            this.lbStatInfo.Location = new System.Drawing.Point(12, 242);
            this.lbStatInfo.Name = "lbStatInfo";
            this.lbStatInfo.Size = new System.Drawing.Size(107, 15);
            this.lbStatInfo.TabIndex = 6;
            this.lbStatInfo.Text = "Trạng thái (STAT):";
            // 
            // lbRssInfo
            // 
            this.lbRssInfo.AutoSize = true;
            this.lbRssInfo.Location = new System.Drawing.Point(12, 186);
            this.lbRssInfo.Name = "lbRssInfo";
            this.lbRssInfo.Size = new System.Drawing.Size(88, 15);
            this.lbRssInfo.TabIndex = 7;
            this.lbRssInfo.Text = "Thông tin RSS:";
            // 
            // lbTTYInfo
            // 
            this.lbTTYInfo.AutoSize = true;
            this.lbTTYInfo.Location = new System.Drawing.Point(12, 214);
            this.lbTTYInfo.Name = "lbTTYInfo";
            this.lbTTYInfo.Size = new System.Drawing.Size(89, 15);
            this.lbTTYInfo.TabIndex = 8;
            this.lbTTYInfo.Text = "Thông tin TTY:";
            // 
            // lbTimeInfo
            // 
            this.lbTimeInfo.AutoSize = true;
            this.lbTimeInfo.Location = new System.Drawing.Point(10, 298);
            this.lbTimeInfo.Name = "lbTimeInfo";
            this.lbTimeInfo.Size = new System.Drawing.Size(103, 15);
            this.lbTimeInfo.TabIndex = 9;
            this.lbTimeInfo.Text = "Thời gian (TIME):";
            // 
            // lbCommand
            // 
            this.lbCommand.AutoSize = true;
            this.lbCommand.Location = new System.Drawing.Point(9, 327);
            this.lbCommand.Name = "lbCommand";
            this.lbCommand.Size = new System.Drawing.Size(146, 15);
            this.lbCommand.TabIndex = 10;
            this.lbCommand.Text = "Lệnh chạy (COMMAND):";
            // 
            // txtUserValue
            // 
            this.txtUserValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserValue.Location = new System.Drawing.Point(185, 39);
            this.txtUserValue.Name = "txtUserValue";
            this.txtUserValue.ReadOnly = true;
            this.txtUserValue.Size = new System.Drawing.Size(386, 22);
            this.txtUserValue.TabIndex = 11;
            // 
            // txtPIDValue
            // 
            this.txtPIDValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPIDValue.Location = new System.Drawing.Point(185, 67);
            this.txtPIDValue.Name = "txtPIDValue";
            this.txtPIDValue.ReadOnly = true;
            this.txtPIDValue.Size = new System.Drawing.Size(386, 22);
            this.txtPIDValue.TabIndex = 12;
            // 
            // txtCPUValue
            // 
            this.txtCPUValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCPUValue.Location = new System.Drawing.Point(185, 95);
            this.txtCPUValue.Name = "txtCPUValue";
            this.txtCPUValue.ReadOnly = true;
            this.txtCPUValue.Size = new System.Drawing.Size(386, 22);
            this.txtCPUValue.TabIndex = 13;
            // 
            // txtMEMValue
            // 
            this.txtMEMValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMEMValue.Location = new System.Drawing.Point(185, 123);
            this.txtMEMValue.Name = "txtMEMValue";
            this.txtMEMValue.ReadOnly = true;
            this.txtMEMValue.Size = new System.Drawing.Size(386, 22);
            this.txtMEMValue.TabIndex = 14;
            // 
            // txtVSZValue
            // 
            this.txtVSZValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtVSZValue.Location = new System.Drawing.Point(185, 151);
            this.txtVSZValue.Name = "txtVSZValue";
            this.txtVSZValue.ReadOnly = true;
            this.txtVSZValue.Size = new System.Drawing.Size(386, 22);
            this.txtVSZValue.TabIndex = 15;
            // 
            // txtRSSValue
            // 
            this.txtRSSValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRSSValue.Location = new System.Drawing.Point(185, 179);
            this.txtRSSValue.Name = "txtRSSValue";
            this.txtRSSValue.ReadOnly = true;
            this.txtRSSValue.Size = new System.Drawing.Size(386, 22);
            this.txtRSSValue.TabIndex = 16;
            // 
            // txtTTYValue
            // 
            this.txtTTYValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTTYValue.Location = new System.Drawing.Point(185, 207);
            this.txtTTYValue.Name = "txtTTYValue";
            this.txtTTYValue.ReadOnly = true;
            this.txtTTYValue.Size = new System.Drawing.Size(386, 22);
            this.txtTTYValue.TabIndex = 17;
            // 
            // txtSTATValue
            // 
            this.txtSTATValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTATValue.Location = new System.Drawing.Point(185, 235);
            this.txtSTATValue.Name = "txtSTATValue";
            this.txtSTATValue.ReadOnly = true;
            this.txtSTATValue.Size = new System.Drawing.Size(386, 22);
            this.txtSTATValue.TabIndex = 18;
            // 
            // txtSTARTValue
            // 
            this.txtSTARTValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSTARTValue.Location = new System.Drawing.Point(185, 263);
            this.txtSTARTValue.Name = "txtSTARTValue";
            this.txtSTARTValue.ReadOnly = true;
            this.txtSTARTValue.Size = new System.Drawing.Size(386, 22);
            this.txtSTARTValue.TabIndex = 19;
            // 
            // txtTIMEValue
            // 
            this.txtTIMEValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTIMEValue.Location = new System.Drawing.Point(185, 291);
            this.txtTIMEValue.Name = "txtTIMEValue";
            this.txtTIMEValue.ReadOnly = true;
            this.txtTIMEValue.Size = new System.Drawing.Size(386, 22);
            this.txtTIMEValue.TabIndex = 20;
            // 
            // txtCOMMANDValue
            // 
            this.txtCOMMANDValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCOMMANDValue.Location = new System.Drawing.Point(12, 345);
            this.txtCOMMANDValue.Multiline = true;
            this.txtCOMMANDValue.Name = "txtCOMMANDValue";
            this.txtCOMMANDValue.ReadOnly = true;
            this.txtCOMMANDValue.Size = new System.Drawing.Size(559, 36);
            this.txtCOMMANDValue.TabIndex = 21;
            // 
            // lbPortRunning
            // 
            this.lbPortRunning.AutoSize = true;
            this.lbPortRunning.Location = new System.Drawing.Point(9, 18);
            this.lbPortRunning.Name = "lbPortRunning";
            this.lbPortRunning.Size = new System.Drawing.Size(91, 15);
            this.lbPortRunning.TabIndex = 22;
            this.lbPortRunning.Text = "Port đang chạy:";
            // 
            // txtPortRunning
            // 
            this.txtPortRunning.Location = new System.Drawing.Point(185, 11);
            this.txtPortRunning.Name = "txtPortRunning";
            this.txtPortRunning.ReadOnly = true;
            this.txtPortRunning.Size = new System.Drawing.Size(386, 22);
            this.txtPortRunning.TabIndex = 23;
            // 
            // FormApplicationInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(583, 393);
            this.Controls.Add(this.txtPortRunning);
            this.Controls.Add(this.lbPortRunning);
            this.Controls.Add(this.txtCOMMANDValue);
            this.Controls.Add(this.txtTIMEValue);
            this.Controls.Add(this.txtSTARTValue);
            this.Controls.Add(this.txtSTATValue);
            this.Controls.Add(this.txtTTYValue);
            this.Controls.Add(this.txtRSSValue);
            this.Controls.Add(this.txtVSZValue);
            this.Controls.Add(this.txtMEMValue);
            this.Controls.Add(this.txtCPUValue);
            this.Controls.Add(this.txtPIDValue);
            this.Controls.Add(this.txtUserValue);
            this.Controls.Add(this.lbCommand);
            this.Controls.Add(this.lbTimeInfo);
            this.Controls.Add(this.lbTTYInfo);
            this.Controls.Add(this.lbRssInfo);
            this.Controls.Add(this.lbStatInfo);
            this.Controls.Add(this.lbStartInfo);
            this.Controls.Add(this.lbVSZInfo);
            this.Controls.Add(this.lbRamInfo);
            this.Controls.Add(this.lbCpuInfo);
            this.Controls.Add(this.lbPidApplication);
            this.Controls.Add(this.lbUser);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormApplicationInfoDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN CHI TIẾT ỨNG DỤNG - ITSHARE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPidApplication;
        private System.Windows.Forms.Label lbCpuInfo;
        private System.Windows.Forms.Label lbRamInfo;
        private System.Windows.Forms.Label lbVSZInfo;
        private System.Windows.Forms.Label lbStartInfo;
        private System.Windows.Forms.Label lbStatInfo;
        private System.Windows.Forms.Label lbRssInfo;
        private System.Windows.Forms.Label lbTTYInfo;
        private System.Windows.Forms.Label lbTimeInfo;
        private System.Windows.Forms.Label lbCommand;
        public System.Windows.Forms.TextBox txtUserValue;
        public System.Windows.Forms.TextBox txtPIDValue;
        public System.Windows.Forms.TextBox txtCPUValue;
        public System.Windows.Forms.TextBox txtMEMValue;
        public System.Windows.Forms.TextBox txtVSZValue;
        public System.Windows.Forms.TextBox txtRSSValue;
        public System.Windows.Forms.TextBox txtTTYValue;
        public System.Windows.Forms.TextBox txtSTATValue;
        public System.Windows.Forms.TextBox txtSTARTValue;
        public System.Windows.Forms.TextBox txtTIMEValue;
        public System.Windows.Forms.TextBox txtCOMMANDValue;
        private System.Windows.Forms.Label lbPortRunning;
        public System.Windows.Forms.TextBox txtPortRunning;
    }
}