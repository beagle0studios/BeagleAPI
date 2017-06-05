using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.Misc.Gaming
{
    public sealed class ComponentManager
    {
	public int tempInt = 435;
        public static Dictionary<string, IComponentCounter> COMPONENTHOLDER = new Dictionary<string, IComponentCounter>();

        public static event EventHandler<ComponentCounterEventArgs> ComponentAdded;
        public static event EventHandler<ComponentCounterEventArgs> ComponentRemoved;

        public static IComponentCounter GetComponentE(string name)
        {
            IComponentCounter win;
            bool gotElement = COMPONENTHOLDER.TryGetValue(name, out win);
            if (gotElement)
                return win;
            else
                return null;
        }

        public static bool Register(IComponentCounter obj, string name)
        {
            try
            {
                COMPONENTHOLDER.Add(name, obj);

                ComponentCounterEventArgs args = new ComponentCounterEventArgs();
                args.component = obj;
                args.Name = name;
                OnComponentAdded(args);

                return true;
            }
            catch (ArgumentException)
            {
                return false;
            }
        }

        public static void Unregister(string name)
        {
            IComponentCounter obj;
            COMPONENTHOLDER.TryGetValue(name, out obj);

            ComponentCounterEventArgs args = new ComponentCounterEventArgs();
            args.component = obj;
            args.Name = name;
            OnComponentRemoved(args);

            COMPONENTHOLDER.Remove(name);
        }

        public static void Unregister(IComponentCounter obj, string name)
        {
            ComponentCounterEventArgs args = new ComponentCounterEventArgs();
            args.component = obj;
            args.Name = name;
            OnComponentRemoved(args);

            COMPONENTHOLDER.Remove(name);
        }

        public static void OnComponentAdded(ComponentCounterEventArgs e)
        {
            ComponentAdded?.Invoke(new object(), e);
        }

        public static void OnComponentRemoved(ComponentCounterEventArgs e)
        {
            ComponentRemoved?.Invoke(new object(), e);
        }
    }
}
