using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Window;

namespace BeagleAPI.OS
{
    public class LoadObjectsStatic
    {
        /// <summary>
        /// All loaded objects for OS.
        /// </summary>
        public static List<IStdWin> LOADEDCOMPS = 
            new List<IStdWin>();
    }
}
