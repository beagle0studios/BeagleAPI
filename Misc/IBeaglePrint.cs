using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Stellt Druckfunktionen für Klassen und Objekte bereit.
    /// </summary>
    public interface IBeaglePrint
    {
        IPrinter GetPrinter { get; }

        void PrintFile(IPrinter printer);
    }
}
