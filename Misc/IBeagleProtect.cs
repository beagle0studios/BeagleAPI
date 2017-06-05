using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Implementiert ein Objekt dieses Interface, kann es vom OSManager
    /// gesichert werden, um bestimmte Vorgänge und Felder nur innerhalb dieses
    /// Objekts zuzulassen.
    /// </summary>
    public interface IBeagleProtect
    {
        bool IsProtected { get; set; }
        void RegisterProtection();
        void Protect();
        void Deprotect();
        IBeagleBase ProtectBase();
        T GetSelfProtected<T>() where T : IBeagleBase;
    }
}
