using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public enum BeagleBaseType
    {
        Window,
        Button,
        Textbox
    }

    /// <summary>
    /// Objekte, die <see cref="IBeagleBase"/> implementieren, sind in der Lage,
    /// das Standardinformationszentrum (StandardMessageCentre, SMC) der API zu nutzen.
    /// </summary>
    public interface IBeagleBase
    {
        BeagleBaseType BBaseType { get; set; }
        Word Title { get; }

        void RegisterToBaseBase();
        void UnregisterBaseBase();
    }
}
