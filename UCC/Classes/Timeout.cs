using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCC.Classes
{
    /// <summary>
    /// Usefull timeout class
    /// </summary>
    public class Timeout
    {

        internal Int32 TimeoutTick;
        internal Int32 Time;

        public Timeout(Int32 Milseconds)
        {
            this.Time = Milseconds;
            Reset();
        }

        public Boolean IsTimedOut
        {
            get
            {

                if (Environment.TickCount >= TimeoutTick)
                    return true;
                else
                    return false;

            }
        }

        public void Reset()
        {
            TimeoutTick = Environment.TickCount + Time;
        }

        public Int32 Left
        {
            get
            {

                if (IsTimedOut)
                    return 0;

                return TimeoutTick - Environment.TickCount;

            }
        }

    }
}
