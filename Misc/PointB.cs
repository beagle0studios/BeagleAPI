using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeagleAPI.Misc
{
    /// <summary>
    /// Eine simple Kopie des <see cref="Point"/>. Kann implizit konvertiert werden.
    /// </summary>
    public struct PointB
    {
        public int x, y;

        public PointB(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static PointB Empty
        {
            get { return new PointB(0, 0); }
        }

        public static implicit operator Point(PointB v)
        {
            return new Point(v.x, v.y);
        }

        public static implicit operator PointB(Point v)
        {
            return new PointB(v.X, v.Y);
        }
    }
}
