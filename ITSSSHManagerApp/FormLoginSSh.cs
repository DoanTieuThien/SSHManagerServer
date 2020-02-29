using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITSSSHManagerApp
{
    public partial class FormLoginSSh : Form
    {
        public DialogResult dialogResult
        {
            get;
            set;
        }

        public FormLoginSSh()
        {
            this.dialogResult = DialogResult.Cancel;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.dialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.dialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
