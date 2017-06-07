using System.Windows.Forms;
using BeagleAPI.Misc;

namespace BeagleAPI.Controls.Tabs
{
    public class TabPageE : TabPage
    {
        private Word _tabTitle = "";

        /// <summary>
        /// Der Titel der TabPage vom Typ Word.
        /// </summary>
        public Word Title
        {
            get { return _tabTitle; }
            set { Text = _tabTitle = value; }
        }
    }
}
