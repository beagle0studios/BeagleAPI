using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Collects every Beagle Component.
    /// </summary>
    public sealed class BeagleBaseBase
    {
        public static Dictionary<string, IBeagleBase> ALLBEAGLES =
            new Dictionary<string, IBeagleBase>();
    }
}
