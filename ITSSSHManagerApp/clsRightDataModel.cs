using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITSSSHManagerApp
{
    public class RightDataModel
    {
        public int read
        {
            get;
            set;
        }

        public int write
        {
            get;
            set;
        }

        public int execute
        {
            get;
            set;
        }

        public String toRightString()
        {
            return Convert.ToString(read + write + execute);
        }
    }
}
