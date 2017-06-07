using System;
using System.Windows.Forms;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.Controls
{
    public class WebBrowserE : WebBrowser
    {
        public event EventHandler<WebBrowserExtendedEventArgs>
            DocumentCompleteExtended;

        private Tabs.TabPageE parentedTab;
        private string title = "";

        public Tabs.TabPageE GetParentedTab
        {
            get { return parentedTab; }
        }
        public string DocTitle
        {
            get { return title; }
            set { title = value; }
        }

        public WebBrowserE(Tabs.TabPageE tapPage)
        {
            ScriptErrorsSuppressed = true;
            IsWebBrowserContextMenuEnabled = false;
            parentedTab = tapPage;
        }

        protected override void OnDocumentCompleted(WebBrowserDocumentCompletedEventArgs e)
        {
            base.OnDocumentCompleted(e);

            WebBrowserExtendedEventArgs ev = new WebBrowserExtendedEventArgs();
            ev.parentTab = parentedTab;
            ev.TimeReached = DateTime.Now;
            ev.title = DocumentTitle;
            ev.Url = e.Url.ToString();
            DocumentCompleteExtended.Invoke(this, ev);
        }
    }
}
