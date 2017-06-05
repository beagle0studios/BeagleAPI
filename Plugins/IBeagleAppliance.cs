using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Plugins
{
    public interface IBeagleAppliance : IBeagleHomePlugInterface
    {
        /// <summary>
        /// Beschreibt eine Methode, die aufgerufen wird, wenn eine Methode aufgerufen wird.
        /// </summary>
        /// <param name="action">Die parameterlose Methode ohne Rückgabewert.</param>
        void MethodEvent(Action action);

        void OnOpenPlugin(object sender, SysDebug.DelegatesEvents.BeaglePluginOpenEventArgs e);
        void OnOpenPlugin(Action performAction);
    }
}
