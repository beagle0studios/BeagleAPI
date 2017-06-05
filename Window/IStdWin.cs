using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Misc;

namespace BeagleAPI.Window
{
    public enum CLOSE_RESULT
    {
        None = 0x00,
        Cancel = 0x01,
        Abort = 0x02,
        Error = 0x03,
        Done = 0x04,
        AlreadyOpen = 0x05,
        UserClose = 0x06,
        UserCloseTaskMan = 0x07
    }

    /// <summary>
    /// Stellt Funktionen bereit, die ein Fenster laut BISO beinhalten muss.
    /// </summary>
    public interface IStdWin : IDisposable, IBeagleable, IBeagleManagable, IBeagleMovable
    {
        string WINDOW_TITLE { get; set; }
        bool IsLoadedToBase { get; set; }
        bool RegisterWindow();
        bool CanClose { get; set; }
        void Open();
        void Open(System.Windows.Forms.Form parent);
        void CloseSelf();
        void CloseSelf(CLOSE_RESULT result);
        void Hide();
        void Show();
        void Close();
        bool ShowInTaskman { get; }
        bool ExitOnClose { get; set; }
        bool IsDisposed { get; }
        DateTime CreationTime { get; set; }
    }
}
