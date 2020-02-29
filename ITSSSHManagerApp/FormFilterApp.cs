using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITSSSHManagerApp
{
    public partial class FormFilterApp : Form
    {
        public DialogResult dialogResult
        {
            get;
            set;
        }

        public FormFilterApp()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.dialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormFilterApp_Load(object sender, EventArgs e)
        {
            this.dialogResult = DialogResult.Cancel;
        }
    }
}
