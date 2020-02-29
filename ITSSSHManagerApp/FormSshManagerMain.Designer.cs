namespace ITSSSHManagerApp
{
    partial class FormMainSShManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainSShManager));
            this.panelServerInformation = new System.Windows.Forms.Panel();
            this.dataApplication = new System.Windows.Forms.DataGridView();
            this.clUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextAppMenuTrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.killApplicationByPID = new System.Windows.Forms.ToolStripMenuItem();
            this.clPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clVsz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupServerInfo = new System.Windows.Forms.GroupBox();
            this.dataServerInformation = new System.Windows.Forms.DataGridView();
            this.clInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolMainMenu = new System.Windows.Forms.ToolStrip();
            this.toolBtnReloadAllParam = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSearchApp = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSearchAppByPort = new System.Windows.Forms.ToolStripButton();
            this.toolBtnShowDetailDfData = new System.Windows.Forms.ToolStripButton();
            this.toolBtnSetRight = new System.Windows.Forms.ToolStripButton();
            this.groupConsoleInfo = new System.Windows.Forms.GroupBox();
            this.txtConsoleLog = new System.Windows.Forms.TextBox();
            this.panelServerInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataApplication)).BeginInit();
            this.contextAppMenuTrip.SuspendLayout();
            this.groupServerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataServerInformation)).BeginInit();
            this.toolMainMenu.SuspendLayout();
            this.groupConsoleInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelServerInformation
            // 
            this.panelServerInformation.BackColor = System.Drawing.SystemColors.Control;
            this.panelServerInformation.Controls.Add(this.dataApplication);
            this.panelServerInformation.Location = new System.Drawing.Point(2, 2);
            this.panelServerInformation.Name = "panelServerInformation";
            this.panelServerInformation.Size = new System.Drawing.Size(471, 259);
            this.panelServerInformation.TabIndex = 0;
            // 
            // dataApplication
            // 
            this.dataApplication.AllowUserToAddRows = false;
            this.dataApplication.AllowUserToDeleteRows = false;
            this.dataApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataApplication.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUser,
            this.clPID,
            this.clCPU,
            this.clMem,
            this.clVsz,
            this.clRss,
            this.clTTY,
            this.clStat,
            this.clStart,
            this.clTime,
            this.clCommand});
            this.dataApplication.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataApplication.Location = new System.Drawing.Point(0, 0);
            this.dataApplication.MultiSelect = false;
            this.dataApplication.Name = "dataApplication";
            this.dataApplication.ReadOnly = true;
            this.dataApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataApplication.Size = new System.Drawing.Size(471, 259);
            this.dataApplication.TabIndex = 0;
            this.dataApplication.DoubleClick += new System.EventHandler(this.dataApplication_DoubleClick);
            // 
            // clUser
            // 
            this.clUser.ContextMenuStrip = this.contextAppMenuTrip;
            this.clUser.HeaderText = "USER";
            this.clUser.Name = "clUser";
            this.clUser.ReadOnly = true;
            // 
            // contextAppMenuTrip
            // 
            this.contextAppMenuTrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.killApplicationByPID});
            this.contextAppMenuTrip.Name = "contextAppMenuTrip";
            this.contextAppMenuTrip.Size = new System.Drawing.Size(146, 26);
            // 
            // killApplicationByPID
            // 
            this.killApplicationByPID.Name = "killApplicationByPID";
            this.killApplicationByPID.Size = new System.Drawing.Size(145, 22);
            this.killApplicationByPID.Text = "Tắt ứng dụng";
            this.killApplicationByPID.Click += new System.EventHandler(this.killApplicationByPID_Click);
            // 
            // clPID
            // 
            this.clPID.ContextMenuStrip = this.contextAppMenuTrip;
            this.clPID.HeaderText = "PID";
            this.clPID.Name = "clPID";
            this.clPID.ReadOnly = true;
            // 
            // clCPU
            // 
            this.clCPU.ContextMenuStrip = this.contextAppMenuTrip;
            this.clCPU.HeaderText = "%CPU";
            this.clCPU.Name = "clCPU";
            this.clCPU.ReadOnly = true;
            // 
            // clMem
            // 
            this.clMem.ContextMenuStrip = this.contextAppMenuTrip;
            this.clMem.HeaderText = "%MEM";
            this.clMem.Name = "clMem";
            this.clMem.ReadOnly = true;
            // 
            // clVsz
            // 
            this.clVsz.ContextMenuStrip = this.contextAppMenuTrip;
            this.clVsz.HeaderText = "VSZ";
            this.clVsz.Name = "clVsz";
            this.clVsz.ReadOnly = true;
            // 
            // clRss
            // 
            this.clRss.ContextMenuStrip = this.contextAppMenuTrip;
            this.clRss.HeaderText = "RSS";
            this.clRss.Name = "clRss";
            this.clRss.ReadOnly = true;
            // 
            // clTTY
            // 
            this.clTTY.ContextMenuStrip = this.contextAppMenuTrip;
            this.clTTY.HeaderText = "TTY";
            this.clTTY.Name = "clTTY";
            this.clTTY.ReadOnly = true;
            // 
            // clStat
            // 
            this.clStat.ContextMenuStrip = this.contextAppMenuTrip;
            this.clStat.HeaderText = "STAT";
            this.clStat.Name = "clStat";
            this.clStat.ReadOnly = true;
            // 
            // clStart
            // 
            this.clStart.ContextMenuStrip = this.contextAppMenuTrip;
            this.clStart.HeaderText = "START";
            this.clStart.Name = "clStart";
            this.clStart.ReadOnly = true;
            // 
            // clTime
            // 
            this.clTime.ContextMenuStrip = this.contextAppMenuTrip;
            this.clTime.HeaderText = "TIME";
            this.clTime.Name = "clTime";
            this.clTime.ReadOnly = true;
            // 
            // clCommand
            // 
            this.clCommand.ContextMenuStrip = this.contextAppMenuTrip;
            this.clCommand.HeaderText = "COMMAND";
            this.clCommand.Name = "clCommand";
            this.clCommand.ReadOnly = true;
            // 
            // groupServerInfo
            // 
            this.groupServerInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupServerInfo.Controls.Add(this.dataServerInformation);
            this.groupServerInfo.Location = new System.Drawing.Point(2, 263);
            this.groupServerInfo.Name = "groupServerInfo";
            this.groupServerInfo.Size = new System.Drawing.Size(471, 206);
            this.groupServerInfo.TabIndex = 1;
            this.groupServerInfo.TabStop = false;
            this.groupServerInfo.Text = "Thông tin máy chủ";
            // 
            // dataServerInformation
            // 
            this.dataServerInformation.AllowUserToAddRows = false;
            this.dataServerInformation.AllowUserToDeleteRows = false;
            this.dataServerInformation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataServerInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataServerInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clInfo,
            this.clValue});
            this.dataServerInformation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataServerInformation.Location = new System.Drawing.Point(3, 18);
            this.dataServerInformation.MultiSelect = false;
            this.dataServerInformation.Name = "dataServerInformation";
            this.dataServerInformation.ReadOnly = true;
            this.dataServerInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataServerInformation.Size = new System.Drawing.Size(465, 185);
            this.dataServerInformation.TabIndex = 0;
            this.dataServerInformation.DoubleClick += new System.EventHandler(this.dataServerInformation_DoubleClick);
            // 
            // clInfo
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clInfo.DefaultCellStyle = dataGridViewCellStyle1;
            this.clInfo.HeaderText = "Thông tin";
            this.clInfo.Name = "clInfo";
            this.clInfo.ReadOnly = true;
            // 
            // clValue
            // 
            this.clValue.HeaderText = "Giá trị";
            this.clValue.Name = "clValue";
            this.clValue.ReadOnly = true;
            // 
            // toolMainMenu
            // 
            this.toolMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.toolMainMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBtnReloadAllParam,
            this.toolBtnSearchApp,
            this.toolBtnSearchAppByPort,
            this.toolBtnShowDetailDfData,
            this.toolBtnSetRight});
            this.toolMainMenu.Location = new System.Drawing.Point(936, 0);
            this.toolMainMenu.Name = "toolMainMenu";
            this.toolMainMenu.Size = new System.Drawing.Size(32, 471);
            this.toolMainMenu.TabIndex = 2;
            this.toolMainMenu.Text = "toolStrip1";
            // 
            // toolBtnReloadAllParam
            // 
            this.toolBtnReloadAllParam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnReloadAllParam.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnReloadAllParam.Image")));
            this.toolBtnReloadAllParam.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnReloadAllParam.Name = "toolBtnReloadAllParam";
            this.toolBtnReloadAllParam.Size = new System.Drawing.Size(29, 20);
            this.toolBtnReloadAllParam.Text = "Tải lại tất cả thông tin trên giao diện hiển thị";
            this.toolBtnReloadAllParam.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolBtnSearchApp
            // 
            this.toolBtnSearchApp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSearchApp.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSearchApp.Image")));
            this.toolBtnSearchApp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSearchApp.Name = "toolBtnSearchApp";
            this.toolBtnSearchApp.Size = new System.Drawing.Size(29, 20);
            this.toolBtnSearchApp.Text = "Tìm kiếm ứng dụng theo điều kiện có sẵn lệnh ps -aux";
            this.toolBtnSearchApp.Click += new System.EventHandler(this.toolBtnSearchApp_Click);
            // 
            // toolBtnSearchAppByPort
            // 
            this.toolBtnSearchAppByPort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSearchAppByPort.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSearchAppByPort.Image")));
            this.toolBtnSearchAppByPort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSearchAppByPort.Name = "toolBtnSearchAppByPort";
            this.toolBtnSearchAppByPort.Size = new System.Drawing.Size(29, 20);
            this.toolBtnSearchAppByPort.Text = "Tìm kiếm ứng dụng theo Port đang chạy theo lệnh netstat -anp";
            this.toolBtnSearchAppByPort.Click += new System.EventHandler(this.toolBtnSearchAppByPort_Click);
            // 
            // toolBtnShowDetailDfData
            // 
            this.toolBtnShowDetailDfData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnShowDetailDfData.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnShowDetailDfData.Image")));
            this.toolBtnShowDetailDfData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnShowDetailDfData.Name = "toolBtnShowDetailDfData";
            this.toolBtnShowDetailDfData.Size = new System.Drawing.Size(29, 20);
            this.toolBtnShowDetailDfData.Text = "Xem chi tiết thông tin ổ đĩa trên máy chủ";
            this.toolBtnShowDetailDfData.Click += new System.EventHandler(this.toolBtnShowDetailDfData_Click);
            // 
            // toolBtnSetRight
            // 
            this.toolBtnSetRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolBtnSetRight.Image = ((System.Drawing.Image)(resources.GetObject("toolBtnSetRight.Image")));
            this.toolBtnSetRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBtnSetRight.Name = "toolBtnSetRight";
            this.toolBtnSetRight.Size = new System.Drawing.Size(29, 20);
            this.toolBtnSetRight.Text = "Phân quyền cho Tệp hoặc thư mục";
            this.toolBtnSetRight.Click += new System.EventHandler(this.toolBtnSetRight_Click);
            // 
            // groupConsoleInfo
            // 
            this.groupConsoleInfo.BackColor = System.Drawing.SystemColors.Control;
            this.groupConsoleInfo.Controls.Add(this.txtConsoleLog);
            this.groupConsoleInfo.Location = new System.Drawing.Point(476, 263);
            this.groupConsoleInfo.Name = "groupConsoleInfo";
            this.groupConsoleInfo.Size = new System.Drawing.Size(465, 203);
            this.groupConsoleInfo.TabIndex = 3;
            this.groupConsoleInfo.TabStop = false;
            this.groupConsoleInfo.Text = "Thông tin tìm kiếm Console";
            // 
            // txtConsoleLog
            // 
            this.txtConsoleLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConsoleLog.Location = new System.Drawing.Point(3, 18);
            this.txtConsoleLog.Multiline = true;
            this.txtConsoleLog.Name = "txtConsoleLog";
            this.txtConsoleLog.ReadOnly = true;
            this.txtConsoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtConsoleLog.Size = new System.Drawing.Size(459, 182);
            this.txtConsoleLog.TabIndex = 0;
            // 
            // FormMainSShManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(968, 471);
            this.Controls.Add(this.groupConsoleInfo);
            this.Controls.Add(this.toolMainMenu);
            this.Controls.Add(this.groupServerInfo);
            this.Controls.Add(this.panelServerInformation);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainSShManager";
            this.Text = "ỨNG DỤNG HỖ TRỢ QUẢN LÝ SSH SERVER - ITSHARE";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMainSShManager_FormClosing);
            this.Load += new System.EventHandler(this.FormMainSShManager_Load);
            this.Resize += new System.EventHandler(this.FormMainSShManager_Resize);
            this.panelServerInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataApplication)).EndInit();
            this.contextAppMenuTrip.ResumeLayout(false);
            this.groupServerInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataServerInformation)).EndInit();
            this.toolMainMenu.ResumeLayout(false);
            this.toolMainMenu.PerformLayout();
            this.groupConsoleInfo.ResumeLayout(false);
            this.groupConsoleInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelServerInformation;
        private System.Windows.Forms.DataGridView dataApplication;
        private System.Windows.Forms.GroupBox groupServerInfo;
        private System.Windows.Forms.DataGridView dataServerInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clValue;
        private System.Windows.Forms.ToolStrip toolMainMenu;
        private System.Windows.Forms.ToolStripButton toolBtnReloadAllParam;
        private System.Windows.Forms.ToolStripButton toolBtnSearchApp;
        private System.Windows.Forms.ToolStripButton toolBtnSearchAppByPort;
        private System.Windows.Forms.GroupBox groupConsoleInfo;
        private System.Windows.Forms.TextBox txtConsoleLog;
        private System.Windows.Forms.ContextMenuStrip contextAppMenuTrip;
        private System.Windows.Forms.ToolStripMenuItem killApplicationByPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCPU;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clVsz;
        private System.Windows.Forms.DataGridViewTextBoxColumn clRss;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStat;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCommand;
        private System.Windows.Forms.ToolStripButton toolBtnShowDetailDfData;
        private System.Windows.Forms.ToolStripButton toolBtnSetRight;
    }
}

