using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Window.StdW;

namespace BeagleAPI.Plugins
{
    public interface IBeaglePlugin
    {
        string Name
        {
            get;
        }

        string ID
        {
            get;
        }

        StdWin Initialize();
        void OpenApp();
    }
}
