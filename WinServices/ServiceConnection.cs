using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.WinServices
{
    public enum SERVICE_COMMAND
    {
        test = 128,
        copybeaglehome = 129,
        getupdatebeaglehome = 130,
        senduserdata = 131,
        empty = 220
    }

    public class ServiceConnection
    {
        public static string BeagleHomeUpdateServiceName = "Beagle Home Service Control";

        public static void SendCommand(string serviceName, SERVICE_COMMAND cmd)
        {
            ServiceController sc = new ServiceController(serviceName, Environment.MachineName);
            ServiceControllerPermission scp = new ServiceControllerPermission(ServiceControllerPermissionAccess.Control, Environment.MachineName, 
                serviceName);//this will grant permission to access the Service
            scp.Assert();
            sc.Refresh();

            sc.ExecuteCommand((int)cmd);
        }

    }
}
