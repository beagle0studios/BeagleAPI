using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Misc;

namespace BeagleAPI.SysDebug
{
    public class ControlSystem<TClass> where TClass : new ()
    {
        private static bool isMainSysReg = false;
        private static TClass mainRegisteredClass;
        private static bool isSetFlag = false;

        public static bool IsMainSysRegistered
        {
            get
            {
                return isMainSysReg;
            }

            set
            {
                if (!isSetFlag)
                {
                    //mainRegisteredClass = TClass;
                    isSetFlag = true;
                    isMainSysReg = value;
                }
            }
        }

        public static TClass GetRegisteredMainWindow()
        {
            return mainRegisteredClass;
        }
    }
}
