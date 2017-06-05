using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Stellt Funktionen bereit, um einen Drucker zu erstellen bzw. bereitszustellen.
    /// </summary>
    public interface IPrinter
    {
        Printer GetPrinter();
        void StopPrinter();
        void StopPrinter(IBeaglePrint printObject);
    }
}
