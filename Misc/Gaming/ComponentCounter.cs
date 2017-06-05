using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc.Gaming
{
    public sealed class ComponentCounter : IComponentCounter
    {
        public ComponentCounter()
        {
            //register at init
        }

        public bool RegisterComponent(IComponentCounter obj, string name)
        {
            return ComponentManager.Register(obj, name);
        }

        public void UnregisterComponent(string name)
        {
            ComponentManager.Unregister(name);
        }

        public void UnregisterComponent(IComponentCounter obj, string name)
        {
            ComponentManager.Unregister(obj, name);
        }
    }
}
