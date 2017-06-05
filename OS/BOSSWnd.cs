using BeagleAPI.Plugins;
using BeagleAPI.Window.StdW;
using System;
using System.Drawing;
using System.Windows.Forms;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.OS
{
    public partial class BOSSWnd : StdWin, IBeagleOSWindow, IBeagleAppliance
    {
        private bool _isOpen = false;
        private PlusAppControl appControl;
        private TableLayoutPanel taskpanel;

        public bool IsOpened
        {
            get
            {
                return _isOpen;
            }

            set
            {
                _isOpen = value;
            }
        }

        public string GetID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string AppType
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Icon AppIcon
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public BOSSWnd(TableLayoutPanel taskPanel_p, StdWin parentWindow)
        {
            InitializeComponent();
            taskpanel = taskPanel_p;
        }

        public PlusAppControl GetAppControl()
        {
            PlusAppControl app = new PlusAppControl();
            app.Dock = DockStyle.Left;
            app.BUTTON.INFORMATION = Name;
            app.BUTTON.GetParent = this;
            app.BUTTON.pluginReference = this;
            app.LABEL.Text = "ogjiojo";
            app.BUTTON.ButtonClicked += BUTTON_ButtonClicked;
            app.BUTTON.BackgroundImage = Icon.ToBitmap();
            app.BUTTON.GetParent = this;
            //appControl = app;
            return app;
        }

        private void BUTTON_ButtonClicked(object sender, ButtonEClickedEventArgs e)
        {
            if(_isOpen)
            {
                _isOpen = false;
                Hide();
            }
            else
            {
                _isOpen = true;
                Show();
            }
        }

        public void ShowInTaskpanel()
        {
            appControl = GetAppControl();
            AddAppControl(taskpanel, ref appControl);
        }

        protected override void OnShown(EventArgs e)
        {
            _isOpen = true;
            base.OnShown(e);
        }

        public void AddAppControl(TableLayoutPanel taskpanel, ref PlusAppControl control)
        {
            taskpanel.Controls.Add(control);
        }

        public void RemoveAppControl(TableLayoutPanel taskpanel, ref PlusAppControl control)
        {
            taskpanel.Controls.Remove(control);
        }

        public void MethodEvent(Action action)
        {
            throw new NotImplementedException();
        }

        public void OnOpenPlugin(object sender, BeaglePluginOpenEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnOpenPlugin(Action performAction)
        {
            throw new NotImplementedException();
        }

        public string GenerateID()
        {
            throw new NotImplementedException();
        }

        public void InstallBeagleHome()
        {
            throw new NotImplementedException();
        }

        public StdWin Initialize()
        {
            throw new NotImplementedException();
        }

        public void SetAppParameters(StdWin window, params string[] args)
        {
            throw new NotImplementedException();
        }

        public StdWin CreateWindow()
        {
            throw new NotImplementedException();
        }
    }
}
