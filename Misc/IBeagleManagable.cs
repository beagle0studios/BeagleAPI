using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Spiegelt Funktionen und Eigenschaften wieder, die es einem Objekt
    /// ermöglichen, in den TaskManager der BeagleAPI aufgenommen zu werden.
    /// </summary>
    public interface IBeagleManagable : IBeagleBase
    {
        IBeagleable GetManager { get; }
        void PutInManager();
    }
}
