using BeagleAPI.Enums.System;
using BeagleAPI.SysDebug.DelegatesEvents;
using System;
using System.Windows.Forms;

namespace BeagleAPI.Controls
{
    public partial class ButtonStdWin : Button
    {
        /// <summary>
        /// Tritt auf, wenn das Element geklickt wird.
        /// </summary>
        public event EventHandler<ButtonStdWinEventArgs> StdWinBtnClick;
        public event EventHandler<DesignChangedEventArgs> DesignChanged;

        private ButtonStdWinEventArgs eventArgs = new ButtonStdWinEventArgs();

        public ButtonStdWin()
        {
            FlatStyle = FlatStyle.Flat;
            InitializeComponent();
        }

        private void OnButtonClicked(ButtonStdWinEventArgs e)
        {
            StdWinBtnClick?.Invoke(this, e);
        }

        public void ChangeDesign(DesignPacks design)
        {
            DesignChangedEventArgs eventArgs = new DesignChangedEventArgs();
            eventArgs.TimeReached = DateTime.Now;
            eventArgs.button = this;
            eventArgs.designPack = design;
            OnDesignChanged(eventArgs);
        }

        private void OnDesignChanged(DesignChangedEventArgs e)
        {
            DesignChanged?.Invoke(this, e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            eventArgs.TimeReached = DateTime.Now;
            eventArgs.ParentObject = this.FindForm();
            OnButtonClicked(eventArgs);
        }
    }
}
