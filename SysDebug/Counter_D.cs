using System;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.SysDebug
{
    public interface IDrawableGet
    {
        void SetActive();
    }

    public class Drawer : IDrawableGet
    {
        public virtual void SetActive()
        {
            System.Windows.Forms.MessageBox.Show("Hallo", "dies ist eine implementierte Schnittstelle in drawer.");
        }
    }

    public class NewDrawerChild : Drawer
    {
        public override void SetActive()
        {
            System.Windows.Forms.MessageBox.Show("Hallo", "dies ist eine implementierte Schnittstelle in der child");
        }
    }

    public sealed class FindDrawableGet
    {
        public static IDrawableGet Find(string name)
        {
            //search for name
            return new Drawer();
        }
    }

    public class Counter_D
    {
        public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

        private int threshold = 0;
        private int total = 0;

        public Counter_D(int passedThreshold)
        {
            threshold = passedThreshold;
        }

        public IDrawableGet Init(string name)
        {
            return CallDrawable(name);
        }

        public IDrawableGet CallDrawable(string name)
        {
            return FindDrawableGet.Find(name);
        }

        public void Add(int x)
        {
            total += x;
            if (total >= threshold)
            {
                ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
                args.Threshold = threshold;
                args.TimeReached = DateTime.Now;
                OnThreasholdReached(args);
            }
        }

        protected virtual void OnThreasholdReached(ThresholdReachedEventArgs e)
        {
            ThresholdReached?.Invoke(this, e);
        }
    }
}
