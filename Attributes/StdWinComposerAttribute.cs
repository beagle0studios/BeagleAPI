using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Attributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class BeagleBaseAttribute : Attribute
    {
        public string Name;
    }

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method)]
    public class StdWinComposerAttribute : BeagleBaseAttribute
    {
        private string _windowname;
        private long _windowid = 0;

        public long WindowID
        {
            get { return _windowid; }
            set { _windowid = value; }
        }

        public StdWinComposerAttribute (string WindowName)
        {
            _windowname = WindowName;
        }
    }
}
