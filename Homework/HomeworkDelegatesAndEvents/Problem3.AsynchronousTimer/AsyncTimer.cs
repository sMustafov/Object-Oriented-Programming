using System;
using System.Threading;

namespace Problem3.AsynchronousTimer
{
    public class AsyncTimer
    {
        private int ticks;
        private int t;

        public AsyncTimer(Action<int> action, int ticks, int t)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.T = t;
        }

        public Action<int> Action { get; private set; }

        public int Ticks
        {
            get
            {
                return this.ticks;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Ticks cannot be negative");
                }
                this.ticks = value;
            }
        }

        public int T
        {
            get
            {
                return this.t;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The time interval (T) cannot be negative");
                }
                this.t = value;
            }
        }

        public void Execute()
        {
            Thread paralelThread = new Thread(this.Run);
            paralelThread.Start();
        }

        public void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.T);

                if (this.Action != null)
                {
                    this.Action(i);
                }
            }
        }
    }
}