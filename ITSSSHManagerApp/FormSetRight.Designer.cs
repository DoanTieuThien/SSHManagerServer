namespace ITSSSHManagerApp
{
    partial class FormSetRight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetRight));
            this.lbPath = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbLine = new System.Windows.Forms.Label();
            this.lbRead = new System.Windows.Forms.Label();
            this.lbWrite = new System.Windows.Forms.Label();
            this.lbExecute = new System.Windows.Forms.Label();
            this.lbPermission = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.lbOther = new System.Windows.Forms.Label();
            this.lbGroup = new System.Windows.Forms.Label();
            this.checkReadOther = new System.Windows.Forms.CheckBox();
            this.checkReadGroup = new System.Windows.Forms.CheckBox();
            this.checkReadOwner = new System.Windows.Forms.CheckBox();
            this.checkExecuteOther = new System.Windows.Forms.CheckBox();
            this.checkExecuteGroup = new System.Windows.Forms.CheckBox();
            this.checkExecuteOwner = new System.Windows.Forms.CheckBox();
            this.checkWriteOther = new System.Windows.Forms.CheckBox();
            this.checkWriteGroup = new System.Windows.Forms.CheckBox();
            this.checkWriteOwner = new System.Windows.Forms.CheckBox();
            this.checkSubFolder = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(12, 9);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(70, 15);
            this.lbPath.TabIndex = 0;
            this.lbPath.Text = "Đường dẫn:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(15, 27);
            this.txtPath.MaxLength = 500;
            this.txtPath.Multiline = true;
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(408, 43);
            this.txtPath.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(304, 209);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(119, 30);
            this.btnApply.TabIndex = 11;
            this.btnApply.Text = "Áp dụng";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLine.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbLine.Location = new System.Drawing.Point(41, 74);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(355, 15);
            this.lbLine.TabIndex = 3;
            this.lbLine.Text = "---------------------------------------------------------------------------------" +
    "------";
            // 
            // lbRead
            // 
            this.lbRead.AutoSize = true;
            this.lbRead.Location = new System.Drawing.Point(150, 99);
            this.lbRead.Name = "lbRead";
            this.lbRead.Size = new System.Drawing.Size(34, 15);
            this.lbRead.TabIndex = 4;
            this.lbRead.Text = "Read";
            // 
            // lbWrite
            // 
            this.lbWrite.AutoSize = true;
            this.lbWrite.Location = new System.Drawing.Point(262, 99);
            this.lbWrite.Name = "lbWrite";
            this.lbWrite.Size = new System.Drawing.Size(36, 15);
            this.lbWrite.TabIndex = 5;
            this.lbWrite.Text = "Write";
            // 
            // lbExecute
            // 
            this.lbExecute.AutoSize = true;
            this.lbExecute.Location = new System.Drawing.Point(364, 99);
            this.lbExecute.Name = "lbExecute";
            this.lbExecute.Size = new System.Drawing.Size(48, 15);
            this.lbExecute.TabIndex = 6;
            this.lbExecute.Text = "Execute";
            // 
            // lbPermission
            // 
            this.lbPermission.AutoSize = true;
            this.lbPermission.Location = new System.Drawing.Point(12, 99);
            this.lbPermission.Name = "lbPermission";
            this.lbPermission.Size = new System.Drawing.Size(46, 15);
            this.lbPermission.TabIndex = 7;
            this.lbPermission.Text = "Quyền:";
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(85, 120);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(45, 15);
            this.lbOwner.TabIndex = 8;
            this.lbOwner.Text = "Owner:";
            // 
            // lbOther
            // 
            this.lbOther.AutoSize = true;
            this.lbOther.Location = new System.Drawing.Point(85, 170);
            this.lbOther.Name = "lbOther";
            this.lbOther.Size = new System.Drawing.Size(40, 15);
            this.lbOther.TabIndex = 9;
            this.lbOther.Text = "Other:";
            // 
            // lbGroup
            // 
            this.lbGroup.AutoSize = true;
            this.lbGroup.Location = new System.Drawing.Point(85, 145);
            this.lbGroup.Name = "lbGroup";
            this.lbGroup.Size = new System.Drawing.Size(43, 15);
            this.lbGroup.TabIndex = 10;
            this.lbGroup.Text = "Group:";
            // 
            // checkReadOther
            // 
            this.checkReadOther.AutoSize = true;
            this.checkReadOther.Location = new System.Drawing.Point(160, 171);
            this.checkReadOther.Name = "checkReadOther";
            this.checkReadOther.Size = new System.Drawing.Size(15, 14);
            this.checkReadOther.TabIndex = 3;
            this.checkReadOther.UseVisualStyleBackColor = true;
            this.checkReadOther.CheckedChanged += new System.EventHandler(this.checkReadOther_CheckedChanged);
            // 
            // checkReadGroup
            // 
            this.checkReadGroup.AutoSize = true;
            this.checkReadGroup.Location = new System.Drawing.Point(160, 146);
            this.checkReadGroup.Name = "checkReadGroup";
            this.checkReadGroup.Size = new System.Drawing.Size(15, 14);
            this.checkReadGroup.TabIndex = 2;
            this.checkReadGroup.UseVisualStyleBackColor = true;
            this.checkReadGroup.CheckedChanged += new System.EventHandler(this.checkReadGroup_CheckedChanged);
            // 
            // checkReadOwner
            // 
            this.checkReadOwner.AutoSize = true;
            this.checkReadOwner.Location = new System.Drawing.Point(160, 121);
            this.checkReadOwner.Name = "checkReadOwner";
            this.checkReadOwner.Size = new System.Drawing.Size(15, 14);
            this.checkReadOwner.TabIndex = 1;
            this.checkReadOwner.UseVisualStyleBackColor = true;
            this.checkReadOwner.CheckStateChanged += new System.EventHandler(this.checkReadOwner_CheckStateChanged);
            // 
            // checkExecuteOther
            // 
            this.checkExecuteOther.AutoSize = true;
            this.checkExecuteOther.Location = new System.Drawing.Point(379, 171);
            this.checkExecuteOther.Name = "checkExecuteOther";
            this.checkExecuteOther.Size = new System.Drawing.Size(15, 14);
            this.checkExecuteOther.TabIndex = 9;
            this.checkExecuteOther.UseVisualStyleBackColor = true;
            this.checkExecuteOther.CheckedChanged += new System.EventHandler(this.checkExecuteOther_CheckedChanged);
            // 
            // checkExecuteGroup
            // 
            this.checkExecuteGroup.AutoSize = true;
            this.checkExecuteGroup.Location = new System.Drawing.Point(379, 146);
            this.checkExecuteGroup.Name = "checkExecuteGroup";
            this.checkExecuteGroup.Size = new System.Drawing.Size(15, 14);
            this.checkExecuteGroup.TabIndex = 8;
            this.checkExecuteGroup.UseVisualStyleBackColor = true;
            this.checkExecuteGroup.CheckedChanged += new System.EventHandler(this.checkExecuteGroup_CheckedChanged);
            // 
            // checkExecuteOwner
            // 
            this.checkExecuteOwner.AutoSize = true;
            this.checkExecuteOwner.Location = new System.Drawing.Point(379, 121);
            this.checkExecuteOwner.Name = "checkExecuteOwner";
            this.checkExecuteOwner.Size = new System.Drawing.Size(15, 14);
            this.checkExecuteOwner.TabIndex = 7;
            this.checkExecuteOwner.UseVisualStyleBackColor = true;
            this.checkExecuteOwner.CheckedChanged += new System.EventHandler(this.checkExecuteOwner_CheckedChanged);
            // 
            // checkWriteOther
            // 
            this.checkWriteOther.AutoSize = true;
            this.checkWriteOther.Location = new System.Drawing.Point(273, 170);
            this.checkWriteOther.Name = "checkWriteOther";
            this.checkWriteOther.Size = new System.Drawing.Size(15, 14);
            this.checkWriteOther.TabIndex = 6;
            this.checkWriteOther.UseVisualStyleBackColor = true;
            this.checkWriteOther.CheckedChanged += new System.EventHandler(this.checkWriteOther_CheckedChanged);
            // 
            // checkWriteGroup
            // 
            this.checkWriteGroup.AutoSize = true;
            this.checkWriteGroup.Location = new System.Drawing.Point(273, 146);
            this.checkWriteGroup.Name = "checkWriteGroup";
            this.checkWriteGroup.Size = new System.Drawing.Size(15, 14);
            this.checkWriteGroup.TabIndex = 5;
            this.checkWriteGroup.UseVisualStyleBackColor = true;
            this.checkWriteGroup.CheckedChanged += new System.EventHandler(this.checkWriteGroup_CheckedChanged);
            // 
            // checkWriteOwner
            // 
            this.checkWriteOwner.AutoSize = true;
            this.checkWriteOwner.Location = new System.Drawing.Point(273, 120);
            this.checkWriteOwner.Name = "checkWriteOwner";
            this.checkWriteOwner.Size = new System.Drawing.Size(15, 14);
            this.checkWriteOwner.TabIndex = 4;
            this.checkWriteOwner.UseVisualStyleBackColor = true;
            this.checkWriteOwner.CheckedChanged += new System.EventHandler(this.checkWriteOwner_CheckedChanged);
            // 
            // checkSubFolder
            // 
            this.checkSubFolder.AutoSize = true;
            this.checkSubFolder.Location = new System.Drawing.Point(15, 216);
            this.checkSubFolder.Name = "checkSubFolder";
            this.checkSubFolder.Size = new System.Drawing.Size(175, 19);
            this.checkSubFolder.TabIndex = 10;
            this.checkSubFolder.Text = "Áp dụng tất cả thư mục con";
            this.checkSubFolder.UseVisualStyleBackColor = true;
            // 
            // FormSetRight
            // 
            this.AcceptButton = this.btnApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(440, 251);
            this.Controls.Add(this.checkSubFolder);
            this.Controls.Add(this.checkWriteOwner);
            this.Controls.Add(this.checkWriteGroup);
            this.Controls.Add(this.checkWriteOther);
            this.Controls.Add(this.checkExecuteOwner);
            this.Controls.Add(this.checkExecuteGroup);
            this.Controls.Add(this.checkExecuteOther);
            this.Controls.Add(this.checkReadOwner);
            this.Controls.Add(this.checkReadGroup);
            this.Controls.Add(this.checkReadOther);
            this.Controls.Add(this.lbGroup);
            this.Controls.Add(this.lbOther);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.lbPermission);
            this.Controls.Add(this.lbExecute);
            this.Controls.Add(this.lbWrite);
            this.Controls.Add(this.lbRead);
            this.Controls.Add(this.lbLine);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lbPath);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSetRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PHÂN QUYỀN TỆP HAY THƯ MỤC - ITSHARE";
            this.Load += new System.EventHandler(this.FormSetRight_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label lbRead;
        private System.Windows.Forms.Label lbWrite;
        private System.Windows.Forms.Label lbExecute;
        private System.Windows.Forms.Label lbPermission;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label lbOther;
        private System.Windows.Forms.Label lbGroup;
        private System.Windows.Forms.CheckBox checkReadOther;
        private System.Windows.Forms.CheckBox checkReadGroup;
        private System.Windows.Forms.CheckBox checkReadOwner;
        private System.Windows.Forms.CheckBox checkExecuteOther;
        private System.Windows.Forms.CheckBox checkExecuteGroup;
        private System.Windows.Forms.CheckBox checkExecuteOwner;
        private System.Windows.Forms.CheckBox checkWriteOther;
        private System.Windows.Forms.CheckBox checkWriteGroup;
        private System.Windows.Forms.CheckBox checkWriteOwner;
        public System.Windows.Forms.CheckBox checkSubFolder;
        public System.Windows.Forms.TextBox txtPath;
    }
}