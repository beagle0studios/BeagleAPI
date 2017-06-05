using BeagleAPI.Plugins;
using BeagleAPI.SysDebug.DelegatesEvents;
using BeagleAPI.Window;
using System;
using System.Windows.Forms;
using BeagleAPI.Enums.System;

namespace BeagleAPI.Controls
{
    public partial class ButtonE : Button, IControlB, Misc.IBeagleBase
    {
        public string INFORMATION;
        public IBeagleAppliance pluginReference;
        public bool EnablePreview = false;

        public event EventHandler<ButtonEClickedEventArgs> ButtonClicked;
        public event EventHandler<StdWinButtonClickedEventArgs> StdWinClicked;
        public event EventHandler<DesignChangedEventArgs> DesignChanged;

        private Action OnClickedAction;
        private ButtonEClickedEventArgs eventArgs = new ButtonEClickedEventArgs();
        private IStdWin PARENT_WIND;
        private IControlB PARENT_CONTROL;
        private bool IsParentControl = false;
        private PreviewWindow win;
        private string name_;
        private bool IsFullyDefined = false;
        private DesignPacks design;

        public string Title
        {
            get
            {
                return Name;
            }
        }

        public IStdWin GetParent
        {
            get
            {
                return PARENT_WIND;
            }

            set
            {
                PARENT_WIND = value;
            }
        }

        public ButtonE()
        {
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            eventArgs = new ButtonEClickedEventArgs();
            name_ = Name + DateTime.Now.ToString();
            design = DesignPacks.Standard;
            RegisterToBaseBase();
        }

        public ButtonE(IStdWin parent)
        {
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            eventArgs = new ButtonEClickedEventArgs();
            PARENT_WIND = parent;
            name_ = Name + DateTime.Now.ToString();
            win = new PreviewWindow(PARENT_WIND);
            design = DesignPacks.Standard;
            RegisterToBaseBase();
            IsFullyDefined = true;
            MouseHover += ButtonE_MouseHover;
        }

        public ButtonE(bool isParentControl, IControlB control)
        {
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            eventArgs = new ButtonEClickedEventArgs();
            PARENT_CONTROL = control;
            IsParentControl = true;
            design = DesignPacks.Standard;
            name_ = Name + DateTime.Now.ToString();
            win = new PreviewWindow(PARENT_WIND);
            RegisterToBaseBase();
            IsFullyDefined = true;
            MouseHover += ButtonE_MouseHover;
        }

        /// <summary>
        /// Give a method that will be run when user clicks on button.
        /// </summary>
        /// <param name="method">"void" without parameters</param>
        public ButtonE(Action method, IStdWin parent)
        {
            base.FlatAppearance.BorderSize = 0;
            base.FlatStyle = FlatStyle.Flat;
            eventArgs = new ButtonEClickedEventArgs();
            OnClickedAction = method;
            PARENT_WIND = parent;
            name_ = Name + DateTime.Now.ToString();
            design = DesignPacks.Standard;
            win = new PreviewWindow(PARENT_WIND);
            RegisterToBaseBase();
            IsFullyDefined = true;
            MouseHover += ButtonE_MouseHover;
        }

        public void ChangeDesign(DesignPacks design)
        {
            DesignChangedEventArgs eventArgs = new DesignChangedEventArgs();
            eventArgs.TimeReached = DateTime.Now;
            eventArgs.designPack = design;
            OnDesignChanged(eventArgs);
        }

        private void OnButtonClicked(ButtonEClickedEventArgs e)
        {
            if (GetParent != null)
            {
                StdWinClicked?.Invoke(this, new StdWinButtonClickedEventArgs(Name, this));
                ButtonClicked?.Invoke(this, e);
                OnClickedAction?.Invoke();
            }
            else
                MessageBox.Show("Button is not initialized. Need to init following: " + Environment.NewLine +
                    Environment.NewLine +
                    "IStdWin parentWindow" + Environment.NewLine +
                    Environment.NewLine +
                    "If you read it as an End-User, please contact software developer.",
                    "Fatal error");
        }


        private void OnDesignChanged(DesignChangedEventArgs e)
        {
            DesignChanged?.Invoke(this, e);
        }

        protected override void OnClick(EventArgs e)
        {
            if (GetParent != null)
            {
                base.OnClick(e);

                eventArgs.TimeReached = DateTime.Now;
                eventArgs.ParentObject = this.FindForm();
                OnButtonClicked(eventArgs);
            }
            else
                MessageBox.Show("Button's important identifications are not set.");
        }

        public void DisposeB()
        {
            UnregisterBaseBase();
            Dispose();
        }

        public void Redraw()
        {
            
        }

        public void Redraw(IControlB parent)
        {
            
        }

        public void Destroy()
        {
            
        }

        public void RegisterToBaseBase()
        {
            //BeagleAPI.Misc.BeagleBaseBase.ALLBEAGLES.Add(name_, this);
        }

        public void UnregisterBaseBase()
        {
            //BeagleAPI.Misc.BeagleBaseBase.ALLBEAGLES.Remove(name_);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            //win.Close();
        }

        private void ButtonE_MouseHover(object sender, EventArgs e)
        {
            //if (EnablePreview)
            //{
            //    win.Location = Location;
            //    win.Show();
            //    Focus();
            //}
        }
    }
}
