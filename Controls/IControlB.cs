using BeagleAPI.SysDebug.DelegatesEvents;
using BeagleAPI.Window;
using System;

namespace BeagleAPI.Controls
{
    public interface IControlB : IDisposable
    {
        string Name { get; set; }
        void DisposeB();
        void Redraw();
        void Redraw(IControlB parent);
        void Destroy();
        IStdWin GetParent { get; set; }
        event EventHandler<StdWinButtonClickedEventArgs> StdWinClicked;
    }
}
