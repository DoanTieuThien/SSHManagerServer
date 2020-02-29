namespace ITSSSHManagerApp
{
    partial class FormDfDataDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDfDataDetail));
            this.picDfDataInfo = new System.Windows.Forms.PictureBox();
            this.datagridDfInfo = new System.Windows.Forms.DataGridView();
            this.clFilesstem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAvail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsePer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clMountedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbHeaderInfo = new System.Windows.Forms.Label();
            this.lbHddStatusInfo = new System.Windows.Forms.Label();
            this.lbFilesystem = new System.Windows.Forms.Label();
            this.lbMountedOn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDfDataInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDfInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // picDfDataInfo
            // 
            this.picDfDataInfo.Image = ((System.Drawing.Image)(resources.GetObject("picDfDataInfo.Image")));
            this.picDfDataInfo.Location = new System.Drawing.Point(12, 12);
            this.picDfDataInfo.Name = "picDfDataInfo";
            this.picDfDataInfo.Size = new System.Drawing.Size(84, 74);
            this.picDfDataInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDfDataInfo.TabIndex = 0;
            this.picDfDataInfo.TabStop = false;
            // 
            // datagridDfInfo
            // 
            this.datagridDfInfo.AllowUserToAddRows = false;
            this.datagridDfInfo.AllowUserToDeleteRows = false;
            this.datagridDfInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridDfInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridDfInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clFilesstem,
            this.clSize,
            this.clUsed,
            this.clAvail,
            this.clUsePer,
            this.clMountedOn});
            this.datagridDfInfo.Location = new System.Drawing.Point(3, 92);
            this.datagridDfInfo.Name = "datagridDfInfo";
            this.datagridDfInfo.ReadOnly = true;
            this.datagridDfInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridDfInfo.Size = new System.Drawing.Size(714, 249);
            this.datagridDfInfo.TabIndex = 1;
            this.datagridDfInfo.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.datagridDfInfo_RowStateChanged);
            // 
            // clFilesstem
            // 
            this.clFilesstem.HeaderText = "Filesystem";
            this.clFilesstem.Name = "clFilesstem";
            this.clFilesstem.ReadOnly = true;
            // 
            // clSize
            // 
            this.clSize.HeaderText = "Size";
            this.clSize.Name = "clSize";
            this.clSize.ReadOnly = true;
            // 
            // clUsed
            // 
            this.clUsed.HeaderText = "Used";
            this.clUsed.Name = "clUsed";
            this.clUsed.ReadOnly = true;
            // 
            // clAvail
            // 
            this.clAvail.HeaderText = "Avail";
            this.clAvail.Name = "clAvail";
            this.clAvail.ReadOnly = true;
            // 
            // clUsePer
            // 
            this.clUsePer.HeaderText = "Use(%)";
            this.clUsePer.Name = "clUsePer";
            this.clUsePer.ReadOnly = true;
            // 
            // clMountedOn
            // 
            this.clMountedOn.HeaderText = "Mounted On";
            this.clMountedOn.Name = "clMountedOn";
            this.clMountedOn.ReadOnly = true;
            // 
            // lbHeaderInfo
            // 
            this.lbHeaderInfo.AutoSize = true;
            this.lbHeaderInfo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHeaderInfo.Location = new System.Drawing.Point(102, 12);
            this.lbHeaderInfo.Name = "lbHeaderInfo";
            this.lbHeaderInfo.Size = new System.Drawing.Size(264, 15);
            this.lbHeaderInfo.TabIndex = 2;
            this.lbHeaderInfo.Text = "THÔNG TIN CHI TIẾT Ổ ĐĨA TRÊN MÁY CHỦ";
            // 
            // lbHddStatusInfo
            // 
            this.lbHddStatusInfo.AutoSize = true;
            this.lbHddStatusInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbHddStatusInfo.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbHddStatusInfo.Location = new System.Drawing.Point(604, 74);
            this.lbHddStatusInfo.Name = "lbHddStatusInfo";
            this.lbHddStatusInfo.Size = new System.Drawing.Size(80, 15);
            this.lbHddStatusInfo.TabIndex = 3;
            this.lbHddStatusInfo.Text = "Tổng số ổ đĩa:";
            // 
            // lbFilesystem
            // 
            this.lbFilesystem.AutoSize = true;
            this.lbFilesystem.Location = new System.Drawing.Point(102, 53);
            this.lbFilesystem.Name = "lbFilesystem";
            this.lbFilesystem.Size = new System.Drawing.Size(67, 15);
            this.lbFilesystem.TabIndex = 4;
            this.lbFilesystem.Text = "Filesystem:";
            // 
            // lbMountedOn
            // 
            this.lbMountedOn.AutoSize = true;
            this.lbMountedOn.Location = new System.Drawing.Point(102, 74);
            this.lbMountedOn.Name = "lbMountedOn";
            this.lbMountedOn.Size = new System.Drawing.Size(79, 15);
            this.lbMountedOn.TabIndex = 5;
            this.lbMountedOn.Text = "Mounted On:";
            // 
            // FormDfDataDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(719, 343);
            this.Controls.Add(this.lbMountedOn);
            this.Controls.Add(this.lbFilesystem);
            this.Controls.Add(this.lbHddStatusInfo);
            this.Controls.Add(this.lbHeaderInfo);
            this.Controls.Add(this.datagridDfInfo);
            this.Controls.Add(this.picDfDataInfo);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDfDataDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN CHI TIẾT Ổ ĐĨA - ITSHARE";
            this.Load += new System.EventHandler(this.FormDfDataDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDfDataInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridDfInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDfDataInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFilesstem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAvail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsePer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMountedOn;
        private System.Windows.Forms.Label lbHeaderInfo;
        private System.Windows.Forms.Label lbHddStatusInfo;
        public System.Windows.Forms.DataGridView datagridDfInfo;
        private System.Windows.Forms.Label lbFilesystem;
        public System.Windows.Forms.Label lbMountedOn;
    }
}