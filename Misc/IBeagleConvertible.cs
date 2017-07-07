using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    public interface IBeagleConvertible : IBeagleBase
    {
        void ConvertTo(IBeagleBase baseObject, IBeagleBase obj, BeagleBaseType toBeagle);
        void UndoConversion();
    }
}
