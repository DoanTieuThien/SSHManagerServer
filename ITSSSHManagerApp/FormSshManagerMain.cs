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
    public partial class FormMainSShManager : Form
    {
        private clsSshControll sshControll = null;

        public FormMainSShManager()
        {
            InitializeComponent();
            this.sshControll = new clsSshControll();
            resizeForm();
        }

        private void FormMainSShManager_Load(object sender, EventArgs e)
        {
            resizeForm();
            FormLoginSSh formLogin = new FormLoginSSh();
            formLogin.ShowDialog();
            if(formLogin.dialogResult == DialogResult.Cancel)
            {
                Application.Exit();
                return;
            }
            try
            {
                this.sshControll.open(formLogin.txtHostAddress.Text, formLogin.txtUserName.Text, formLogin.txtPassword.Text, Convert.ToInt32(formLogin.txtPort.Text), 120);
            }
            catch(Exception exp)
            {
                MessageBox.Show("Lỗi kết nối: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FormMainSShManager_Load(sender, e);
            }
            loadPsAux("");
            loadServerInfor();
        }

        private void FormMainSShManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.sshControll != null)
            {
                this.sshControll.close();
                this.sshControll = null;
            }
        }

        private void resizeForm()
        {
            this.panelServerInformation.Left = 5;
            this.panelServerInformation.Top = 5;
            this.panelServerInformation.Height = (this.Height -5)/2;
            this.panelServerInformation.Width = (this.Width - 5) / 2; 

            //------------

            this.groupServerInfo.Left = 5;
            this.groupServerInfo.Top = (this.Height - 5) / 2 + 5;
            this.groupServerInfo.Width = (this.Width - 5) / 2; 
            this.groupServerInfo.Height = (this.Height - 5) / 2 - 40;

            //------------

            this.groupConsoleInfo.Left = (this.Width - 5) / 2 - this.toolMainMenu.Width + 30;
            this.groupConsoleInfo.Top = (this.Height - 5) / 2 + 5;
            this.groupConsoleInfo.Width = (this.Width - 5) / 2 - this.toolMainMenu.Width - 17;
            this.groupConsoleInfo.Height = (this.Height - 5) / 2 - 40;
        }

        private void FormMainSShManager_Resize(object sender, EventArgs e)
        {
            resizeForm();
        }

        private void loadPsAux(String grepData)
        {
            try
            {
                String psAuxData = this.sshControll.read("ps -aux" + grepData);
                String[] psAuxArrayData = psAuxData.Split('\n');
                List<PsAuxDataModel> dataListTemp = new List<PsAuxDataModel>();

                foreach (String line in psAuxArrayData)
                {
                    String[] dataLineArray = line.Replace(" ", ";").Split(';');
                    if (dataLineArray == null || dataLineArray.Length < 11)
                    {
                        continue;
                    }
                    List<String> psInfoList = new List<string>();

                    foreach (String data in dataLineArray)
                    {
                        String dataTemp = data.Trim();
                        if(dataTemp.Equals(""))
                        {
                            continue;
                        }
                        psInfoList.Add(dataTemp);
                    }
                    if(psInfoList.Count < 11)
                    {
                        continue;
                    }
                    PsAuxDataModel psAuxDataModel = new PsAuxDataModel();

                    psAuxDataModel.user = psInfoList[0];
                    psAuxDataModel.pid = psInfoList[1];
                    psAuxDataModel.cpu = psInfoList[2];
                    psAuxDataModel.mem = psInfoList[3];
                    psAuxDataModel.vsz = psInfoList[4];
                    psAuxDataModel.rss = psInfoList[5];
                    psAuxDataModel.tty = psInfoList[6];
                    psAuxDataModel.stat = psInfoList[7];
                    psAuxDataModel.start = psInfoList[8];
                    psAuxDataModel.time = psInfoList[9];
                    int count = psInfoList.Count;
                    StringBuilder command = new StringBuilder();

                    for (int i = 10; i < count; i ++)
                    {
                        command.Append(psInfoList[i] + " ");
                    }
                    psAuxDataModel.command = command.ToString();
                    dataListTemp.Add(psAuxDataModel);
                }
                dataListTemp.RemoveAt(0);
                foreach (PsAuxDataModel psAuxDataModel in dataListTemp)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.dataApplication);

                    row.Cells[0].Value = psAuxDataModel.user;
                    row.Cells[1].Value = psAuxDataModel.pid;
                    row.Cells[2].Value = psAuxDataModel.cpu;
                    row.Cells[3].Value = psAuxDataModel.mem;
                    row.Cells[4].Value = psAuxDataModel.vsz;
                    row.Cells[5].Value = psAuxDataModel.rss;
                    row.Cells[6].Value = psAuxDataModel.tty;
                    row.Cells[7].Value = psAuxDataModel.stat;
                    row.Cells[8].Value = psAuxDataModel.start;
                    row.Cells[9].Value = psAuxDataModel.time;
                    row.Cells[10].Value = psAuxDataModel.command;
                    this.dataApplication.Rows.Add(row);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Lỗi xử lý: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadServerInfor()
        {
            try
            {
                String freeMemory = this.sshControll.read("free -k");
                List<FreeDataModel> dataFreeMemList = loadFreeMemory(freeMemory);

                foreach (FreeDataModel freeDataModel in dataFreeMemList)
                {
                    this.dataServerInformation.Rows.Add(new Object[] { freeDataModel.type, freeDataModel.total + "KB" });
                }
                String ifconfigData = this.sshControll.read("ifconfig");
                this.dataServerInformation.Rows.Add(new Object[] { "Network:", ifconfigData.Trim()});
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi xử lý: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<FreeDataModel> loadFreeMemory(String freemMemory)
        {
            List<FreeDataModel> dataFreeMemList = new List<FreeDataModel>();
            String[] psAuxArrayData = freemMemory.Split('\n');

            foreach (String line in psAuxArrayData)
            {
                String[] dataLineArray = line.Replace(" ", ";").Split(';');
                if (dataLineArray == null || dataLineArray.Length < 6)
                {
                    continue;
                }
                List<String> psInfoList = new List<string>();

                foreach (String data in dataLineArray)
                {
                    String dataTemp = data.Trim();
                    if (dataTemp.Equals(""))
                    {
                        continue;
                    }
                    psInfoList.Add(dataTemp);
                }
                if(psInfoList.Count != 4 && psInfoList.Count != 7)
                {
                    continue;
                }

                FreeDataModel freeDataModel = new FreeDataModel();
                String type = psInfoList[0];
                if ("-/+".Equals(type))
                {
                    freeDataModel.type = psInfoList[0] + psInfoList[1];
                    freeDataModel.total = psInfoList[2];
                    freeDataModel.used = psInfoList[3];
                }
                else
                {
                    freeDataModel.type = psInfoList[0];
                    freeDataModel.total = psInfoList[1];
                    freeDataModel.used = psInfoList[2];
                    freeDataModel.free = psInfoList[3];
                }
              
                if (psInfoList.Count == 7)
                {
                    freeDataModel.shared = psInfoList[4];
                    freeDataModel.buffCache = psInfoList[5];
                    freeDataModel.available = psInfoList[6];
                }
                dataFreeMemList.Add(freeDataModel);
            }
            return dataFreeMemList;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.dataApplication.Rows.Clear();
            this.dataServerInformation.Rows.Clear();
            loadPsAux("");
            loadServerInfor();
        }

        private void dataApplication_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataApplication.SelectedRows[0];
                FormApplicationInfoDetail formApplicationInfoDetail = new FormApplicationInfoDetail();
                String pid = Convert.ToString(row.Cells[1].Value);
                String listnerPortData = this.sshControll.read("netstat -anp | grep " + pid);
                String[] psAuxArrayData = listnerPortData.Split('\n');
                String listenerApp = "";

                foreach (String line in psAuxArrayData)
                {
                    if(line.IndexOf("LISTEN") > 0)
                    {
                        listenerApp = line.Trim().Replace(" " ,";");
                        break;
                    }
                }
                String port = "";

                if (!listenerApp.Equals(""))
                {
                    String[] arrayDataPort = listenerApp.Split(';');
                    List<String> dataTemp = new List<string>();

                    foreach (String line in arrayDataPort)
                    {
                        String l = line.Trim();

                        if ("".Equals(l))
                        {
                            continue;
                        }
                        dataTemp.Add(l);
                    }
                    if (dataTemp.Count > 4)
                    {
                        String s = dataTemp[3].Replace(":", " ").Trim();
                        try
                        {
                            int p = Convert.ToInt32(s);
                            port = s;
                        }
                        catch (Exception exp)
                        {
                            Console.WriteLine(exp.Message);
                            try
                            {
                                port = s.Substring(s.IndexOf(" ")).Trim();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                    } 
                }
                formApplicationInfoDetail.txtPortRunning.Text = port;
                formApplicationInfoDetail.txtUserValue.Text = Convert.ToString(row.Cells[0].Value); ;
                formApplicationInfoDetail.txtPIDValue.Text = pid;
                formApplicationInfoDetail.txtCPUValue.Text = Convert.ToString(row.Cells[2].Value);
                formApplicationInfoDetail.txtMEMValue.Text = Convert.ToString(row.Cells[3].Value);
                formApplicationInfoDetail.txtVSZValue.Text = Convert.ToString(row.Cells[4].Value);
                formApplicationInfoDetail.txtRSSValue.Text = Convert.ToString(row.Cells[5].Value);
                formApplicationInfoDetail.txtTTYValue.Text = Convert.ToString(row.Cells[6].Value);
                formApplicationInfoDetail.txtSTATValue.Text = Convert.ToString(row.Cells[7].Value);
                formApplicationInfoDetail.txtSTARTValue.Text = Convert.ToString(row.Cells[8].Value);
                formApplicationInfoDetail.txtTIMEValue.Text = Convert.ToString(row.Cells[9].Value);
                formApplicationInfoDetail.txtCOMMANDValue.Text = Convert.ToString(row.Cells[10].Value);
                formApplicationInfoDetail.ShowDialog();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }

        private void toolBtnSearchApp_Click(object sender, EventArgs e)
        {
            FormFilterApp formFilterApp = new FormFilterApp();
            formFilterApp.ShowDialog();
            if(formFilterApp.dialogResult != DialogResult.OK)
            {
                return;
            }
            this.dataApplication.Rows.Clear();
            String temp = formFilterApp.txtSearchValue.Text.Trim();
            if (temp.Equals(""))
            {
                loadPsAux("");
            }
            else
            {
                loadPsAux(" | grep " + temp);
            }
        }

        private void toolBtnSearchAppByPort_Click(object sender, EventArgs e)
        {
            FormFilterApp formFilterApp = new FormFilterApp();
            formFilterApp.ShowDialog();
            if (formFilterApp.dialogResult != DialogResult.OK)
            {
                return;
            }
            try
            {
                String temp = formFilterApp.txtSearchValue.Text.Trim();
                if (temp.Equals(""))
                {
                    this.txtConsoleLog.Text = this.sshControll.read("netstat -anp");
                }
                else
                {
                    this.txtConsoleLog.Text = this.sshControll.read("netstat -anp | grep " + temp);
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
}

        private void killApplicationByPID_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataApplication.SelectedRows[0];
                FormApplicationInfoDetail formApplicationInfoDetail = new FormApplicationInfoDetail();
                String pid = Convert.ToString(row.Cells[1].Value);
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn tắt ứng dụng với PID " + pid + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    String data = this.sshControll.read("kill -9 " + pid);
                    this.txtConsoleLog.Text = data;
                    loadPsAux("");
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi xử lý: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadDfInfo()
        {
            try
            {
                String dfData = this.sshControll.read("df -h");
                String[] psAuxArrayData = dfData.Split('\n');
                List<DfDataModel> dataListTemp = new List<DfDataModel>();

                foreach (String line in psAuxArrayData)
                {
                    String[] dataLineArray = line.Replace(" ", ";").Split(';');
                    if (dataLineArray == null || dataLineArray.Length < 11)
                    {
                        continue;
                    }
                    List<String> psInfoList = new List<string>();

                    foreach (String data in dataLineArray)
                    {
                        String dataTemp = data.Trim();
                        if (dataTemp.Equals(""))
                        {
                            continue;
                        }
                        psInfoList.Add(dataTemp);
                    }
                    int count = psInfoList.Count;
                    if (count <  6)
                    {
                        continue;
                    }
                    DfDataModel dfDataModel = new DfDataModel();

                    dfDataModel.fileSystem = psInfoList[0];
                    dfDataModel.size = psInfoList[1];
                    dfDataModel.used = psInfoList[2];
                    dfDataModel.available = psInfoList[3];
                    dfDataModel.usePer = psInfoList[4];
                    StringBuilder dataTempBuilder = new StringBuilder();
                    for (int i = 5; i < count; i++)
                    {
                        dataTempBuilder.Append(psInfoList[i] + " ");
                    }
                    dfDataModel.mountedOn = dataTempBuilder.ToString();
                    dataListTemp.Add(dfDataModel);
                }
                dataListTemp.RemoveAt(0);
                FormDfDataDetail formDfDataDetail = new FormDfDataDetail();

                foreach(DfDataModel df in dataListTemp)
                {
                    formDfDataDetail.datagridDfInfo.Rows.Add(new Object[] {df.fileSystem,df.size,df.used,df.available,df.usePer,df.mountedOn });
                }
                formDfDataDetail.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi thực thi lệnh df -h, xin hãy kiểm tra lại disk on os", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolBtnShowDetailDfData_Click(object sender, EventArgs e)
        {
            loadDfInfo();
        }

        private void dataServerInformation_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = this.dataServerInformation.SelectedRows[0];
                FormShowInfoDetail formShowInfoDetail = new FormShowInfoDetail();

                formShowInfoDetail.lbKeyInfo.Text = "Thông tin tham số: " + row.Cells[0].Value;
                formShowInfoDetail.txtParamValue.Text = Convert.ToString(row.Cells[1].Value);
                formShowInfoDetail.ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Lỗi xử lý: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolBtnSetRight_Click(object sender, EventArgs e)
        {
            try
            {
                FormSetRight formSetRight = new FormSetRight();
                formSetRight.ShowDialog();

                if (formSetRight.dialogResult != DialogResult.OK)
                {
                    return;
                }
                Dictionary<String, RightDataModel> dic = formSetRight.rightPermissionDic;
                StringBuilder dataRight = new StringBuilder();

                if (dic.ContainsKey("OWNER"))
                {
                    dataRight.Append(dic["OWNER"].toRightString());
                }
                else
                {
                    dataRight.Append(0);
                }
                if (dic.ContainsKey("GROUP"))
                {
                    dataRight.Append(dic["GROUP"].toRightString());
                }
                else
                {
                    dataRight.Append(0);
                }
                if (dic.ContainsKey("OTHER"))
                {
                    dataRight.Append(dic["OTHER"].toRightString());
                }
                else
                {
                    dataRight.Append(0);
                }
                if (formSetRight.checkSubFolder.Checked)
                {
                    this.txtConsoleLog.Text = this.sshControll.read("chmode -R " + dataRight.ToString() + " " + formSetRight.txtPath.Text);
                }
                else
                {
                    this.txtConsoleLog.Text = this.sshControll.read("chmode " + dataRight.ToString() + " " + formSetRight.txtPath.Text);
                }
            }
            catch(Exception exp)
            {
                MessageBox.Show("Lỗi xử lý: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
