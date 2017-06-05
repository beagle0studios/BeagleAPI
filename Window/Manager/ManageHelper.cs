using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Window.Manager
{
    public class ManageHelper : IEnumerable<IStdWin>
    {
        public static readonly Dictionary<string, IStdWin> window_collection = new Dictionary<string, IStdWin>();
        
        private static readonly string stringStartupWindowName = "osStartup_beagle_c";

        public ManageHelper()
        {

        }

        public static CLOSE_RESULT h__openStartupWindow()
        {
            IStdWin win;
            bool isDone;
            isDone = window_collection.TryGetValue(stringStartupWindowName, out win);
            if (isDone)
            {
                win.Open();
                return CLOSE_RESULT.Done;
            }
            else
                return CLOSE_RESULT.Error;
        }

        public static void h__returnAllRegistations()
        {

            string[] r = new string[window_collection.Count];

            //foreach (string s in r)
            foreach (var s in window_collection)
            {
                System.Windows.Forms.MessageBox.Show(s.Key, s.Value.WINDOW_TITLE);
            }
        }

        public static List<string> h__returnAllRegistationsKeys()
        {

            List<string> r = new List<string>();

            foreach (var s in window_collection)
            {
                r.Add(s.Key);
            }
            return r;
        }

        public static List<string> h__returnAllRegistationsTitle()
        {

            List<string> r = new List<string>();

            foreach (var s in window_collection)
            {
                r.Add(s.Value.WINDOW_TITLE);
            }
            return r;
        }

        public static void h__returnRegistationAt(string name)
        {
            IStdWin win;
            bool a = window_collection.TryGetValue(name, out win);
            System.Windows.Forms.MessageBox.Show(win.WINDOW_TITLE, "title");
        }

        public IEnumerator<IStdWin> GetEnumerator()
        {
            foreach (var item in window_collection)
            {
                yield return item.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            foreach (var item in window_collection)
            {
                yield return item.Value;
            }
        }
    }
}
