using System;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Stellt Funktionen bereit, ein <see cref="BeagleAPI.Window.StdW.StdWin"/>
    /// bewegbar zu machen.
    /// </summary>
    public interface IBeagleMovable : IBeagleBase
    {
        bool IsMoving { get; set; }
        void StopMoving();
    }
}
