using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace ITSSSHManagerApp
{
    public class clsSshControll
    {
        private SshClient sshClient = null;
        private int timeout = 120;

        public Boolean open(String host, String userName, String password, int port, int timeout)
        {
            try
            {
                this.sshClient = new SshClient(host, port, userName, password);
                this.sshClient.ConnectionInfo.Timeout = TimeSpan.FromSeconds(timeout);
                this.sshClient.KeepAliveInterval = TimeSpan.FromSeconds(5);
                this.sshClient.Connect();
                this.timeout = timeout;
                return true;
            }
            catch(Exception exp)
            {
                throw exp;
            }
        }

        public String read(String commandText)
        {
            if(this.sshClient == null)
            {
                return "";
            }
            SshCommand sshCommand = this.sshClient.RunCommand(commandText);

            if (sshCommand == null)
            {
                return "";
            }
            sshCommand.CommandTimeout = TimeSpan.FromSeconds(this.timeout);
            return sshCommand.Execute();
        }

        public void close()
        {
            if(this.sshClient != null)
            {
                this.sshClient.Disconnect();
                this.sshClient = null;
            }
        }
    }
}
