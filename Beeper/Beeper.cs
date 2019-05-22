using System;
using System.Diagnostics;

namespace Beeper
{
    public class Beeper
    {
        private readonly int _timeUnit;

        public Beeper(int timeUnit)
        {
            _timeUnit = timeUnit;
        }

        public long Beep(int times)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.Beep(800, times*_timeUnit);
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }
    }
}
