using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc.Gaming
{
    public interface IComponentCounter
    {
        bool RegisterComponent(IComponentCounter obj, string name);
        void UnregisterComponent(string name);
        void UnregisterComponent(IComponentCounter obj, string name);
    }
}
