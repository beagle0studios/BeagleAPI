using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Stellt die Basisklassenimplementierung dar, die IPrinter implementiert und
    /// einen Drucker bereitstellt.
    /// </summary>
    public class Printer : IPrinter
    {
        public Printer GetPrinter()
        {
            throw new NotImplementedException();
        }

        public void StopPrinter()
        {
            throw new NotImplementedException();
        }

        public void StopPrinter(IBeaglePrint printObject)
        {
            throw new NotImplementedException();
        }
    }
}
