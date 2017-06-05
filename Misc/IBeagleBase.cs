using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Objekte, die <see cref="IBeagleBase"/> implementieren, sind in der Lage,
    /// das Standardinformationszentrum (StandardMessageCentre, SMC) der API zu nutzen.
    /// </summary>
    public interface IBeagleBase
    {
        string Title{ get; }
        void RegisterToBaseBase();
        void UnregisterBaseBase();
    }
}
