using BeagleAPI.Misc;
using BeagleAPI.SysDebug.DelegatesEvents;
using BeagleAPI.Window.Manager;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace BeagleAPI.Window.StdW
{
    public partial class StdWin : Form, IStdWin
    {
        #region Fields

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public event EventHandler<PropertyChangedEventBeagle> PropertyChanged;

        private Word windowTitle;
        public Word WindowName;
        private CLOSE_RESULT CLRES = CLOSE_RESULT.None;
        private DateTime creationTime;
        private bool _isDisposed;
        private PropertyChangedEventBeagle ARGS_ = new PropertyChangedEventBeagle();

        public bool ExitOnClose { get; set; }

        protected bool HideParentWindow = false;
        protected IStdWin ParentWindow;

        #endregion

        #region Constructors

        public StdWin()
        {
            InitializeComponent();
            windowTitle = lblWindowTitle.Text;
            WINDOW_TITLE = windowTitle;
            WindowName = this.ToString() + WINDOW_TITLE;
            buttonStdWin1.DesignChanged += ButtonStdWin1_DesignChanged;
            ARGS_ = new PropertyChangedEventBeagle();
        }

        public void ChangeDesignPack(Enums.System.DesignPacks design)
        {
            buttonStdWin1.ChangeDesign(design);
        }

        private void ButtonStdWin1_DesignChanged(object sender, DesignChangedEventArgs e)
        {
            switch (e.designPack)
            {
                case Enums.System.DesignPacks.Standard:
                    e.button.ForeColor = Color.Black;
                    break;
                case Enums.System.DesignPacks.Inverted:
                    e.button.ForeColor = Color.White;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Constructor of main window class.
        /// </summary>
        /// <param name="exitAppOnExitBtn">Checks if the complete Application should close.</param>
        public StdWin(bool exitAppOnExitBtn)
        {
            InitializeComponent();
            windowTitle = lblWindowTitle.Text;
            WINDOW_TITLE = windowTitle;
            WindowName = this.ToString() + WINDOW_TITLE;
            buttonStdWin1.DesignChanged += ButtonStdWin1_DesignChanged;
            ARGS_ = new PropertyChangedEventBeagle();
            ExitOnClose = exitAppOnExitBtn;
        }

        public StdWin(bool HideParent, IStdWin parent)
        {
            InitializeComponent();
            WINDOW_TITLE = windowTitle;
            WindowName = this.ToString() + WINDOW_TITLE;
            ParentWindow = parent;
            HideParentWindow = true;
            parent.HideWindow();
            ARGS_ = new PropertyChangedEventBeagle();
        }

        #endregion

        #region Eigenschaften

        [Category("Darstellung"), Description("Gibt den Titel des Fensters an.")]
        public Word Title
        {
            get { return lblWindowTitle.Text; }
            set { lblWindowTitle.Text = windowTitle = value; }
        }

        private bool _isHidden;
        public bool IsHidden
        {
            get { return _isHidden; }
            set { _isHidden = value; }
        }

        protected WINDOWTYPE _windowType = WINDOWTYPE.Standard;
        public WINDOWTYPE WindowType
        {
            get { return _windowType; }
        }

        private short _id = (short)(new Random().Next(10000, 30000));
        public short ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool BlackOut
        {
            set
            {
                buttonStdWin1.ForeColor = Color.White;
                buttonStdWin1.BackColor = Color.Black;
                lblWindowTitle.ForeColor = Color.White;
                lblWindowTitle.BackColor = Color.Black;
            }
        }

        public Word WINDOW_TITLE
        {
            get
            {
                return windowTitle;
            }
            set
            {
                lblWindowTitle.Text = windowTitle = value;
                ARGS_.Property = windowTitle;
                OnPropertyChanged(ARGS_);
            }
        }

        private bool _showInTaskman = true;
        public bool ShowInTaskman
        {
            get { return _showInTaskman; }
            set { _showInTaskman = value; }
        }

        public bool ShowCloseButton
        {
            get
            {
                return buttonStdWin1.Visible;
            }
            set
            {
                buttonStdWin1.Visible = value;
            }
        }

        public Color WindowTitleColor
        {
            get { return lblWindowTitle.ForeColor; }
            set { lblWindowTitle.ForeColor = value; }
        }

        public DateTime CreationTime
        {
            get
            {
                return creationTime;
            }

            set
            {
                creationTime = value;
            }
        }

        bool IStdWin.IsDisposed
        {
            get
            {
                return _isDisposed;
            }
        }

        private bool isLoadedBase = false;
        public bool IsLoadedToBase
        {
            get
            {
                return isLoadedBase;
            }

            set
            {
                isLoadedBase = value;
            }
        }

        private bool isMoving_ = false;
        public bool IsMoving
        {
            get
            {
                return isMoving_;
            }

            set
            {
                isMoving_ = value;
            }
        }

        public IBeagleable GetMainBeagle
        {
            get
            {
                return this;
            }
        }

        public IBeagleable GetManager
        {
            get
            {
                return this;
            }
        }

        private bool _canClose;
        public bool CanClose
        {
            get
            {
                return _canClose;
            }

            set
            {
                _canClose = value;
            }
        }

        public IPrinter GetPrinter
        {
            get
            {
                Printer printer = new Printer();
                return printer;
            }
        }

        public bool IsActive
        {
            get
            {
                return Focused;
            }

            set
            {
                throw new NotImplementedException();
            }
        }

<<<<<<< HEAD
        public StdWin GetSelf
        {
            get
            {
                return this;
            }
        }

        public Icon GetIcon
        {
            get
            {
                return this.Icon;
            }
        }

=======
>>>>>>> STDWIN
        public IStdWin this[string name]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region Methods

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                isMoving_ = true;

            }
            else
            {
                StopMoving();
            }
        }

        private void buttonStdWin1_Click(object sender, EventArgs e)
        {
            if (!ExitOnClose)
                this.Close();
            else
                Application.Exit(new CancelEventArgs(true));
        }

        private void ButtonStdWin1_StdWinBtnClick(object sender, SysDebug.DelegatesEvents.ButtonStdWinEventArgs e)
        {
        }

        public void Open(Form parent)
        {
            //nothing to open
        }

        public void CloseSelf(CLOSE_RESULT result)
        {
            WindowName = this.ToString() + WINDOW_TITLE;
            if (result != CLOSE_RESULT.AlreadyOpen)
            {
                WindowManager.UnregisterWindow(WindowName);
                //UnregisterBaseBase();
            }
        }

        public void Open()
        {
            if (RegisterWindow())
            {
                _isHidden = false;
                Show();
            }
            else
            {
                Message.Messages m =
                    new Message.Messages("Achtung", "Es wurde bereits eine Instanz des Programms geöffnet." +
                    Environment.NewLine + "Wir als Entwickler arbeiten bereits daran, dass " +
                    "dann auch das offene Programm hervorgeholt wird, falls es im Hintergrund läuft.", true);
                CLRES = CLOSE_RESULT.AlreadyOpen;
                Close();
            }
        }

        public bool RegisterWindow()
        {
            CreationTime = DateTime.Now;
            WindowName = this.ToString() + WINDOW_TITLE;
            return WindowManager.RegisterWindow(this, WindowName);
        }

        protected override void OnShown(EventArgs e)
        {
            Open();
            //RegisterToBaseBase();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _isDisposed = true;
            if (HideParentWindow && !ParentWindow.IsDisposed)
                ParentWindow.Show();
            CloseSelf(CLRES);
        }

        public void CloseSelf()
        {
            //close self is not implemented yet.
        }

        /// <summary>
        /// Stellt das Objekt dem BeagleAPI-Manager bereit.
        /// </summary>
        public void PutInManager()
        {
            OS.LoadObjectsStatic.LOADEDCOMPS.Add(this);
        }

        public void StopMoving()
        {
            isMoving_ = false;
        }

        public void RegisterToBaseBase()
        {
            BeagleBaseBase.ALLBEAGLES.Add(Title, this);
        }

        public void UnregisterBaseBase()
        {
            BeagleBaseBase.ALLBEAGLES.Remove(Title);
        }

        public void OnPropertyChanged(PropertyChangedEventBeagle e)
        {
            PropertyChanged?.Invoke(new object(), e);
        }

        public void PrintFile(IPrinter printer)
        {
            //nothing to do right now
        }

        public void AddControl(Control control)
        {
            Controls.Add(control);
        }

        public void RefreshSelf()
        {
            Refresh();
        }

        public bool Compare<T>(T objectToCompare)
        {
            return false;
        }

        public bool CompareSelf<T>(T objectToCompare, IBeagleCompare objectSelf)
        {
            return false;
        }
        
        private void buttonStdWin2_Click(object sender, EventArgs e)
        {
            this.HideWindow();
        }

        public void HideWindow()
        {
            _isHidden = true;
            Hide();
        }

        #endregion

    }
}
