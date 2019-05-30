using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace Beeper
{
    public class Beeper
    {
        private readonly int _timeUnit;
        private static Dictionary<string, int> _dictionary = new Dictionary<string, int>
        {
            {".", 1},
            {"-", 3 },
            {" ", 7},
            {"|", 3}
        };

        public Beeper(int timeUnit) => _timeUnit = timeUnit;

        public long Beep(int times)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            const int frequency = 800;
            Console.Beep(frequency, times * _timeUnit);
            stopwatch.Stop();

            return stopwatch.ElapsedMilliseconds;
        }

        public long MorseToBeep(string morseCode)
        {
            long sum = 0;

            foreach (var item in morseCode.Select((value, i) => (value, i)))
            {
                char currentCharacter = item.value;
                const int nextCharacterPosition = 1;
                int index = item.i + nextCharacterPosition;
                int times = _dictionary[currentCharacter.ToString()];

                if (currentCharacter != ' ' && currentCharacter != '|')
                {
                    sum += Beep(times);

                    if (index < morseCode.Length && (morseCode[index] != ' ' && morseCode[index] != '|'))
                    {
                        const int unitTime = 1;
                        sum += GoToSleep(unitTime);
                    }
                }
                else
                {
                    sum += GoToSleep(times);
                }
            }

            return sum;
        }

        private int GoToSleep(int times)
        {
            int time = times * _timeUnit;
            Thread.Sleep(time);

            return time;
        }
    }
}
