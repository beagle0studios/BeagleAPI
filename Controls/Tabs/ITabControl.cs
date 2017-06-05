using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Controls.Tabs
{
    public enum OpenTabMode
    {
        _blank,
        _auto,
        _url,
        _none,
        _secret
    }

    public interface ITabControlE
    {
        void CloseTab();
        void OpenTab();
        void OpenTab(string url);
        void OpenTab(int jumpFromTabIndex);
        void OpenTab(OpenTabMode mode);
    }
}
