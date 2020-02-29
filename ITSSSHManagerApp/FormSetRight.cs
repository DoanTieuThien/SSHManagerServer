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
    public partial class FormSetRight : Form
    {
        public DialogResult dialogResult
        {
            get;
            set;
        }

        public Dictionary<String, RightDataModel> rightPermissionDic
        {
            get;
            set;
        }

        public FormSetRight()
        {
            InitializeComponent();
            this.rightPermissionDic = new Dictionary<string, RightDataModel>();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            this.dialogResult = DialogResult.OK;
        }

        private void FormSetRight_Load(object sender, EventArgs e)
        {
            this.dialogResult = DialogResult.Cancel;
        }

        private void checkReadOwner_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("OWNER", "READ", 4);
            }
            else
            {
                loadRight("OWNER", "READ", 0);
            }
        }

        public void loadRight(String type, String rightType, int rightCode)
        {
            RightDataModel rightDataModel = null;
            if (rightPermissionDic.ContainsKey(type))
            {
                rightDataModel = rightPermissionDic[type];
                rightPermissionDic.Remove(type);
            }
            else
            {
                rightDataModel = new RightDataModel();
            }
            if ("READ".Equals(rightType))
            {
                rightDataModel.read = rightCode;
            }
            else if ("WRITE".Equals(rightType))
            {
                rightDataModel.write = rightCode;
            }
            else if ("EXECUTE".Equals(rightType))
            {
                rightDataModel.execute = rightCode;
            }
            rightPermissionDic.Add(type, rightDataModel);
        }

        private void checkReadGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("GROUP", "READ", 4);
            }
            else
            {
                loadRight("GROUP", "READ", 0);
            }
        }

        private void checkReadOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("OTHER", "READ", 4);
            }
            else
            {
                loadRight("OTHER", "READ", 0);
            }
        }

        private void checkWriteOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("OWNER", "WRITE", 2);
            }
            else
            {
                loadRight("OWNER", "WRITE", 0);
            }
        }

        private void checkWriteGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("GROUP", "WRITE", 2);
            }
            else
            {
                loadRight("GROUP", "WRITE", 0);
            }
        }

        private void checkWriteOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("OTHER", "WRITE", 2);
            }
            else
            {
                loadRight("OTHER", "WRITE", 0);
            }
        }

        private void checkExecuteOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("OWNER", "EXECUTE", 1);
            }
            else
            {
                loadRight("OWNER", "EXECUTE", 0);
            }
        }

        private void checkExecuteGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("GROUP", "EXECUTE", 1);
            }
            else
            {
                loadRight("GROUP", "EXECUTE", 0);
            }
        }

        private void checkExecuteOther_CheckedChanged(object sender, EventArgs e)
        {
            if (checkReadOwner.Checked)
            {
                loadRight("OTHER", "EXECUTE", 1);
            }
            else
            {
                loadRight("OTHER", "EXECUTE", 0);
            }
        }
    }
}
