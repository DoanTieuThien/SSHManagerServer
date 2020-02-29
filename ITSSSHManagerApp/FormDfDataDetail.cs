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
    public partial class FormDfDataDetail : Form
    {
        public FormDfDataDetail()
        {
            InitializeComponent();
        }

        private void FormDfDataDetail_Load(object sender, EventArgs e)
        {
            this.lbHddStatusInfo.Text = "Tổng số ổ đĩa: " + this.datagridDfInfo.Rows.Count;
        }

        private void datagridDfInfo_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                DataGridViewRow row = e.Row;
                lbFilesystem.Text = "Filesystem: " +  Convert.ToString(row.Cells[0].Value);
                lbMountedOn.Text = "Mounted On: " + Convert.ToString(row.Cells[5].Value);
            }
            catch(Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
    }
}
