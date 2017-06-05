using BeagleAPI.SysDebug.DelegatesEvents;
using BeagleAPI.Window;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BeagleAPI.Controls
{
    public partial class Grouper : UserControl, IControlB
    {
        [Category("Darstellung"), Description("Gibt den darzustellenden Text an.")]
        public string GrouperText
        {
            get { return lblGrouperText.Text; }
            set { lblGrouperText.Text = value; }
        }

        public IStdWin GetParent
        {
            get
            {
                return (IStdWin)Parent;
            }

            set
            {
                
            }
        }

        public Grouper()
        {
            InitializeComponent();
        }

        public event EventHandler<StdWinButtonClickedEventArgs> StdWinClicked;

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            StdWinButtonClickedEventArgs args = new StdWinButtonClickedEventArgs();
            args.Name = Name;
            args.ControlSelf = this;
            StdWinClicked?.Invoke(this, args);
        }
        public void DisposeB()
        {
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
    }
}
