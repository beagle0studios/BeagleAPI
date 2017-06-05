using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.Window.Manager
{
    public class WindowManager
    {

        public static event EventHandler<StdWinRegisterEventArgs> WhenRegisterWindow;
        public static event EventHandler<StdWinUnregisterEventArgs> WhenUnregisterWindow;

        public WindowManager()
        {
        }

        public static IStdWin GetWindow(string name)
        {
            IStdWin win;
            bool gotElement = ManageHelper.window_collection.TryGetValue(name, out win);
            if (gotElement)
                return win;
            else
                return null;
        }

        public static bool RegisterWindow(IStdWin window, string name)
        {
            try
            {
                ManageHelper.window_collection.Add(name, window);

                StdWinRegisterEventArgs args = new StdWinRegisterEventArgs();
                args.window = window;
                args.Name = name;
                OnWindowRegistered(args);

                return true;
            }
            catch (ArgumentException)
            {
                //ManageHelper.window_collection.Add(name, window);
                return false;
            }
        }

        public static bool UnregisterWindow(string name)
        {
            StdWinUnregisterEventArgs args = new StdWinUnregisterEventArgs();

            IStdWin window;
            ManageHelper.window_collection.TryGetValue(name, out window);

            args.window = window;
            args.Name = name;
            OnWindowUnregistered(args);

            bool done = ManageHelper.window_collection.Remove(name);
            return done;
        }

        public static void OnWindowRegistered(StdWinRegisterEventArgs e)
        {
            WhenRegisterWindow?.Invoke(new object(), e);
        }

        public static void OnWindowUnregistered(StdWinUnregisterEventArgs e)
        {
            WhenUnregisterWindow?.Invoke(new object(), e);
        }
    }
}
