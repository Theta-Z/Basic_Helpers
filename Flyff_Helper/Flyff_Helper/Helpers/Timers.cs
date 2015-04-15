using System;
using System.Windows.Forms;

namespace FlyFF_Helper.Helpers
{
    /// <summary>
    /// Wrappers for different types of timers.
    /// </summary>
    public class Timers
    {
        /// <summary>
        ///  Wrapper for a one use timer.
        /// </summary>
        /// <param name="ms">The amount of time [in MS] to wait before doing the action.</param>
        /// <param name="voidPtr">The void* to use inside the timer.</param>
        public static void OneUseTimer(int ms, Action voidPtr)
        {
            var timer = new Timer();
            timer.Tick += new EventHandler(
                (obj,evnt) => 
                {
                    voidPtr.Invoke();
                    ((Timer)obj).Stop();
                });
            timer.Interval = ms;
            timer.Start();
        }
    }
}
