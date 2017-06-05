using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BeagleAPI.Controls
{
    public class Resizing
    {
        public Color GrabRectColor = Color.Yellow;
        private Control[] GrabRects = new Control[] { new Control(), new Control(), new Control(), new Control(), new Control(), new Control(), new Control(), new Control() };
        private int GRS = 6;
        private bool InResizeMode;
        private Point LastMousePos;
        private Control mControl;
        private int mMinHeigth = 20;
        private int mMinWidth = 20;
        private bool MoveControl;
        private Control mOwnerForm;
        private int static_GrabRectMouseMove_Bottom;
        private int static_GrabRectMouseMove_Right;
        private bool IsEnabled = true;

        public Resizing(Control NewControl, Control OwnerForm)
        {
            this.mControl = NewControl;
            this.mOwnerForm = OwnerForm;
            this.mOwnerForm.Paint += new PaintEventHandler(this.Paint);
            this.mControl.MouseDown += new MouseEventHandler(this.ControlMouseDown);
            this.mControl.MouseMove += new MouseEventHandler(this.ControlMouseMove);
            this.mControl.MouseUp += new MouseEventHandler(this.ControlMouseUp);
            this.mControl.Cursor = Cursors.SizeAll;
            for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
            {
                this.GrabRects[i].Paint += new PaintEventHandler(this.GrabRectPaint);
                this.GrabRects[i].MouseClick += new MouseEventHandler(this.GrabRectMouseClick);
                this.GrabRects[i].MouseMove += new MouseEventHandler(this.GrabRectMouseMove);
                this.GrabRects[i].MouseDown += new MouseEventHandler(this.GrabRectMouseDown);
                this.GrabRects[i].MouseUp += new MouseEventHandler(this.GrabRectMouseUp);
                this.GrabRects[i].Move += new EventHandler(this.GrabRectMove);
            }
            this.mOwnerForm.Refresh();
        }

        private void ControlMouseDown(object sender, MouseEventArgs e)
        {
            this.MoveControl = true;
            this.LastMousePos = new Point(e.X, e.Y);
            for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
            {
                this.GrabRects[i].Visible = false;
            }
            this.mOwnerForm.Refresh();
        }

        private void ControlMouseMove(object sender, MouseEventArgs e)
        {
            if (this.MoveControl)
            {
                this.mControl.Left = (this.mControl.Left + e.X) - this.LastMousePos.X;
                this.mControl.Top = (this.mControl.Top + e.Y) - this.LastMousePos.Y;
                this.mOwnerForm.Refresh();
            }
        }

        private void ControlMouseUp(object sender, MouseEventArgs e)
        {
            this.MoveControl = false;
            for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
            {
                this.GrabRects[i].Visible = true;
            }
            this.mOwnerForm.Refresh();
        }

        public void Finish()
        {
            if (IsEnabled)
            {
                this.mOwnerForm.Paint -= new PaintEventHandler(this.Paint);
                this.mControl.MouseDown -= new MouseEventHandler(this.ControlMouseDown);
                this.mControl.MouseMove -= new MouseEventHandler(this.ControlMouseMove);
                this.mControl.MouseUp -= new MouseEventHandler(this.ControlMouseUp);
                for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
                {
                    this.GrabRects[i].Paint -= new PaintEventHandler(this.GrabRectPaint);
                    this.GrabRects[i].MouseClick -= new MouseEventHandler(this.GrabRectMouseClick);
                    this.GrabRects[i].MouseMove -= new MouseEventHandler(this.GrabRectMouseMove);
                    this.GrabRects[i].MouseDown -= new MouseEventHandler(this.GrabRectMouseDown);
                    this.GrabRects[i].MouseUp -= new MouseEventHandler(this.GrabRectMouseUp);
                    this.GrabRects[i].Move -= new EventHandler(this.GrabRectMove);
                    this.GrabRects[i].Dispose();
                }
                Cursor.Current = Cursors.Default;
                this.GrabRects = null;
                this.mOwnerForm.Refresh();
                IsEnabled = false;
            }
        }

        private int GetCurrIndex(object sender)
        {
            int num = 0;
            Control objB = (Control)sender;
            for (int i = 0; i < this.GrabRects.Length; i++)
            {
                if (object.ReferenceEquals(this.GrabRects[i], objB))
                {
                    num = i;
                }
            }
            return num;
        }

        private void GrabRectMouseClick(object sender, MouseEventArgs e)
        {
            Control control1 = (Control)sender;
            this.GetCurrIndex(sender);
        }

        private void GrabRectMouseDown(object sender, MouseEventArgs e)
        {
            this.InResizeMode = true;
            for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
            {
                this.GrabRects[i].Visible = false;
            }
            this.mOwnerForm.Refresh();
        }

        private void GrabRectMouseMove(object sender, MouseEventArgs e)
        {
            Control control = (Control)sender;
            int currIndex = this.GetCurrIndex(sender);
            switch (currIndex)
            {
                case 0:
                    control.Cursor = Cursors.SizeNWSE;
                    break;

                case 1:
                    control.Cursor = Cursors.SizeNS;
                    break;

                case 2:
                    control.Cursor = Cursors.SizeNESW;
                    break;

                case 3:
                    control.Cursor = Cursors.SizeWE;
                    break;

                case 4:
                    control.Cursor = Cursors.SizeWE;
                    break;

                case 5:
                    control.Cursor = Cursors.SizeNESW;
                    break;

                case 6:
                    control.Cursor = Cursors.SizeNS;
                    break;

                case 7:
                    control.Cursor = Cursors.SizeNWSE;
                    break;
            }
            if (!this.InResizeMode)
            {
                this.static_GrabRectMouseMove_Right = this.mControl.Right;
                this.static_GrabRectMouseMove_Bottom = this.mControl.Bottom;
            }
            else
            {
                this.mOwnerForm.PointToClient(Cursor.Position);
                control.Left = this.mOwnerForm.PointToClient(Cursor.Position).X;
                control.Top = this.mOwnerForm.PointToClient(Cursor.Position).Y;
                int height = 0;
                int width = 0;
                switch (currIndex)
                {
                    case 4:
                        width = this.GrabRects[4].Left - this.mControl.Left;
                        if (width < this.mMinWidth)
                        {
                            width = this.mMinWidth;
                        }
                        this.mControl.Width = width;
                        break;

                    case 6:
                        height = control.Top - this.mControl.Top;
                        if (height < this.mMinHeigth)
                        {
                            height = this.mMinHeigth;
                        }
                        this.mControl.Height = height;
                        break;

                    case 7:
                        height = control.Top - this.mControl.Top;
                        width = control.Left - this.mControl.Left;
                        if (height < this.mMinHeigth)
                        {
                            height = this.mMinHeigth;
                        }
                        if (width < this.mMinWidth)
                        {
                            width = this.mMinWidth;
                        }
                        this.mControl.Size = new Size(width, height);
                        break;
                }
                this.mOwnerForm.Refresh();
            }
        }

        private void GrabRectMouseUp(object sender, MouseEventArgs e)
        {
            this.InResizeMode = false;
            for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
            {
                this.GrabRects[i].Visible = true;
            }
            this.mOwnerForm.Refresh();
        }

        private void GrabRectMove(object sender, EventArgs e)
        {
            Control control1 = (Control)sender;
            this.GetCurrIndex(sender);
        }

        private void GrabRectPaint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.GRS - 1, this.GRS - 1));
        }

        public void Paint(object sender, PaintEventArgs e)
        {
            if (!(this.InResizeMode | this.MoveControl))
            {
                e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(this.mControl.Location.X - (this.GRS / 2), this.mControl.Location.Y - (this.GRS / 2), this.mControl.Width + this.GRS, this.mControl.Height + this.GRS));
                Point[] pointArray = new Point[] { new Point(this.mControl.Location.X - this.GRS, this.mControl.Location.Y - this.GRS), new Point((this.mControl.Location.X + (this.mControl.Width / 2)) - (this.GRS / 2), this.mControl.Location.Y - this.GRS), new Point(this.mControl.Location.X + this.mControl.Width, this.mControl.Location.Y - this.GRS), new Point(this.mControl.Location.X - this.GRS, (this.mControl.Location.Y + (this.mControl.Height / 2)) - (this.GRS / 2)), new Point(this.mControl.Location.X + this.mControl.Width, (this.mControl.Location.Y + (this.mControl.Height / 2)) - (this.GRS / 2)), new Point(this.mControl.Location.X - this.GRS, this.mControl.Location.Y + this.mControl.Height), new Point((this.mControl.Location.X + (this.mControl.Width / 2)) - (this.GRS / 2), this.mControl.Location.Y + this.mControl.Height), new Point(this.mControl.Location.X + this.mControl.Width, this.mControl.Location.Y + this.mControl.Height) };
                for (int i = 0; i <= (this.GrabRects.Length - 1); i++)
                {
                    this.GrabRects[i].Location = pointArray[i];
                    this.GrabRects[i].Size = new Size(this.GRS, this.GRS);
                    this.GrabRects[i].BackColor = Color.White;
                    this.GrabRects[i].Parent = this.mOwnerForm;
                }
                this.GrabRects[4].BackColor = this.GrabRectColor;
                this.GrabRects[6].BackColor = this.GrabRectColor;
                this.GrabRects[7].BackColor = this.GrabRectColor;
            }
        }
    }
}
