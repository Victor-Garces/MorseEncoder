using NUnit.Framework;

namespace Beeper.Test
{
    [TestFixture]
    public sealed class BeeperTest
    {
        private static int _timeUnit = 500;
        private static int _rangeGap = 5;


        [TestCase(3, 1500)]
        public void Given_One_Time_Unit_Beep(int times, int output)
        {
            Beeper beeper = new Beeper(_timeUnit);

            long beep = beeper.Beep(times);

            Assert.That(beep, Is.InRange(output - _rangeGap, output + _rangeGap));
        }

        [TestCase("...",2500)]
        [TestCase("|", 1500)]
        [TestCase(" ", 3500)]
        [TestCase("...|", 4000)]
        [TestCase("...|...", 6500)]
        [TestCase("...|---|...", 13500)]
        [TestCase("...|---|... ...|---|...", 30500)]
        public void Given_A_Morse_Encoded_Beep_Code(string input, int output)
        {
            Beeper beeper = new Beeper(_timeUnit);
            long time = beeper.MorseToBeep(input);

            Assert.That(time, Is.InRange(output - _rangeGap, output + _rangeGap));
        }
    }
}
