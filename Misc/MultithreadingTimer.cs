using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeagleAPI.SysDebug.DelegatesEvents;

namespace BeagleAPI.Misc
{
    public class MultithreadingTimer
    {
        public event EventHandler<TimerEndEventArgs> TimerEnd;

        private int currentState = 0;
        private int timerLength;
        private TimerEndEventArgs args;

        public MultithreadingTimer(int timerLength)
        {
            this.timerLength = timerLength;
            args = new TimerEndEventArgs();

        }

        private void TimerUpdate()
        {
            if(currentState >= timerLength)
            {
                args.TimeReached = DateTime.Now;
                OnTimerEnd();
            }
        }

        private void OnTimerEnd()
        {
            TimerEnd?.Invoke(this, args);
        }
    }
}
