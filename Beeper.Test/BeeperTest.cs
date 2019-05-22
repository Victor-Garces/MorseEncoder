using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Beeper.Test
{

    [TestFixture]
    public sealed class BeeperTest
    {
        [TestCase(3, 1500)]
        public void Given_One_Time_Unit_Beep(int times, int output)
        {
            const int timeUnit = 500;
            Beeper beeper = new Beeper(timeUnit);

            long beep = beeper.Beep(times);

            Assert.That(beep, Is.InRange(output, output));
        }
    }
}
