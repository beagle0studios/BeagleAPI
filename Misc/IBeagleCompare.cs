using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Objecte, die IBeagleCompare implementieren, können vom Beagle Vergleichszentrum
    /// aufgenommen und verglichen werden.
    /// </summary>
    public interface IBeagleCompare
    { 
        bool Compare<T>(T objectToCompare);
        bool CompareSelf<T>(T objectToCompare, IBeagleCompare objectSelf);
    }
}
