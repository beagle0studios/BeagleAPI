using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Enums.AppPacks;
using BeagleAPI.Enums.System;

namespace BeagleAPI
{
    public class Initialize
    {
        public static void InitializeAPI(string key)
        {
            Window.Message.Messages m = new Window.Message.Messages("Init failed.", "Init failed.", true);
        }

        public static RESULTCODE StartApp(APPLIST app = APPLIST.None)
        {
            switch (app)
            {
                case APPLIST.None:
                    return RESULTCODE.NONE;
                case APPLIST.BeagleX:
                    return RESULTCODE.SUCCESS;
                default:
                    break;
            }
            return RESULTCODE.ERR_NOAPPOPENED;
        }
    }
}
