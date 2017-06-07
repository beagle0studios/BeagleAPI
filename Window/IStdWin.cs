using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.Misc;

namespace BeagleAPI.Window
{
    [Flags]
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

    public enum WINDOWTYPE
    {
        Standard,
        Message,
        Warning,
        Error
    }
    //TODO:
    //Auf dem Desktop alle WINDOW TYPES in der Taskbar gruppieren.

    /// <summary>
    /// Stellt Funktionen bereit, die ein Fenster laut BSWINN beinhalten muss.
    /// Kann auch von Subklassen von System.Windows.Forms.Form implementiert werden.
    /// </summary>
    public interface IStdWin : IDisposable, IBeagleable, IBeagleManagable, IBeagleMovable, IBeagleCompare, IBeaglePrint
    {
        #region Properties
        Word WINDOW_TITLE { get; set; }
        bool IsLoadedToBase { get; set; }
        bool RegisterWindow();
        bool CanClose { get; set; }
        bool ShowInTaskman { get; }
        bool ExitOnClose { get; set; }
        bool IsDisposed { get; }
        bool IsHidden { get; set; }
        bool IsActive { get; set; }
        short ID { get; set; }
        StdW.StdWin GetSelf { get; }
        System.Drawing.Icon GetIcon { get; }
        WINDOWTYPE WindowType { get; }
        DateTime CreationTime { get; set; }
        #endregion

        #region Methos
        void Open();
        void Open(System.Windows.Forms.Form parent);
        void CloseSelf();
        void CloseSelf(CLOSE_RESULT result);
        void HideWindow();
        void Show();
        void Close();
        void RefreshSelf();
        void AddControl(System.Windows.Forms.Control control);
        #endregion

        #region Indexer
        IStdWin this[string name] { get; }
        #endregion
    }
}
