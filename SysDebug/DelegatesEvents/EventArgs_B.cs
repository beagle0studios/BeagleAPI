using BeagleAPI.Window.StdW;
using System;
using System.Drawing;

namespace BeagleAPI.SysDebug.DelegatesEvents
{
    /// <summary>
    /// Main EventArgs with more specific fields.
    /// </summary>
    public class BeagleEventArgs : EventArgs
    {
        public DateTime TimeReached { get; set; }
    }

    /// <summary>
    /// Checks the password typed in. IsValid returns true for correct pw and false for incorrent.
    /// TimeReached returns the time when the user has entered password.
    /// </summary>
    public class EnteredPasswordEventArgs : BeagleEventArgs
    {
        public bool IsValid { get; set; }
    }

    /// <summary>
    /// Caused when a threshold is reached.
    /// </summary>
    public class ThresholdReachedEventArgs : BeagleEventArgs
    {
        public int Threshold { get; set; }
    }

    /// <summary>
    /// Caused when a buttonE was clicked.
    /// </summary>
    public class ButtonEClickedEventArgs : BeagleEventArgs
    {
        public Point ClickPosition;
        public System.Windows.Forms.Form ParentObject;
        public Window.IStdWin OpenWindow;
    }

    /// <summary>
    /// Caused when a timer gets stopped.
    /// </summary>
    public class TimerEndEventArgs : BeagleEventArgs
    {

    }

    /// <summary>
    /// StdWin Button EventArgs
    /// </summary>
    public class ButtonStdWinEventArgs : ButtonEClickedEventArgs
    {
        public ButtonStdWinEventArgs() { }
    }

    /// <summary>
    /// Caused when a Plugin gets opened.
    /// </summary>
    public class BeaglePluginOpenEventArgs : BeagleEventArgs
    {

    }

    /// <summary>
    /// Caused when a StdWin gets registered
    /// </summary>
    public class StdWinRegisterEventArgs : BeagleEventArgs
    {
        public string Name;
        public Window.IStdWin window;
    }

    /// <summary>
    /// Caused when a StdWin gets unregistered
    /// </summary>
    public class StdWinUnregisterEventArgs : BeagleEventArgs
    {
        public string Name;
        public Window.IStdWin window;
    }

    /// <summary>
    /// Caused when a Component was added or removed.
    /// </summary>
    public class ComponentCounterEventArgs : BeagleEventArgs
    {
        public string Name;
        public Misc.Gaming.IComponentCounter component;
    }

    /// <summary>
    /// Caused on property changing. Needs to BoxConverting "Property"
    /// </summary>
    public class PropertyChangedEventBeagle : BeagleEventArgs
    {
        public object Property;
    }

    public class DesignChangedEventArgs : BeagleEventArgs
    {
        public Controls.ButtonStdWin button;
        public Enums.System.DesignPacks designPack;
    }

    /// <summary>
    /// Caused when a StdWinButton was clicked.
    /// </summary>
    public class StdWinButtonClickedEventArgs : BeagleEventArgs
    {
        public StdWinButtonClickedEventArgs()
        { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name of control</param>
        /// <param name="selfParent">[0]: ControlSelf; [1]: Parent</param>
        public StdWinButtonClickedEventArgs(string name, params Controls.IControlB[] selfParent)
        {
            Name = name;
            ControlSelf = selfParent[0];
            Parent = selfParent[1];
        }

        public string Name;
        public Controls.IControlB ControlSelf;
        public Controls.IControlB Parent;
    }

    public class WebBrowserExtendedEventArgs : BeagleEventArgs
    {
        public WebBrowserExtendedEventArgs()
        { }

        public string Url;
        public string title;
        public Controls.Tabs.TabPageE parentTab;
    }
}
