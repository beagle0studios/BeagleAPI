using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    [Serializable()]
    public class ConfigInfo
    {
        public string accesskey = "00000000";
        public string accesRestr = "none";
        public string certKey = "0cb 3vr 8rd 9qf 5th 1wf";
        public DateTime expireDate = DateTime.Now;
    }
}
