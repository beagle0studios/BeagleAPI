using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Stellt eine Möglichkeit bereit, das aufgerufene Objekt in eine statische
    /// Klasse aufzunehmen, um es anderen Objekten bereitzustellen.
    /// </summary>
    public interface IBeagleable : IBeagleBase
    {
        IBeagleable GetMainBeagle { get; }
    }
}
