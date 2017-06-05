using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Enums.System;

namespace BeagleAPI.OS
{
    public interface IBeagleOSApp : BeagleAPI.Plugins.IBeagleAppliance
    {
        string Name { get; set; }
        System.Drawing.Icon AppIcon { get; set; }
        bool IsOpen { get; set; }
        string GUID { get; }
        Window.IStdWin GetSelf { get; }
        Window.IStdWin GetParent { get; }

        /// <summary>
        /// Simply open app
        /// </summary>
        void OpenApp();

        /// <summary>
        /// Open app with arguments.
        /// </summary>
        /// <param name="args">Arguments, i.e. "-opensilent"</param>
        void OpenApp(string[] args);

        /// <summary>
        /// Close app.
        /// </summary>
        /// <returns><see cref="RESULTCODE"/></returns>
        RESULTCODE CloseApp();

        /// <summary>
        /// Closes app.
        /// </summary>
        /// <param name="arg">List of arguments. Example: "0" (no args)</param>
        /// <returns><see cref="RESULTCODE"/></returns>
        RESULTCODE CloseApp(int[] arg);

        /// <summary>
        /// Initializes app.
        /// </summary>
        /// <param name="sender">Sender opening app</param>
        /// <returns>Returns created window for app</returns>
        Window.StdW.StdWin Initialize(Window.IStdWin sender);
    }
}
