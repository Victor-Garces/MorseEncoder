using NUnit.Framework;
using ConsoleApp1;

namespace MorseViewController.Test
{
    [TestFixture]
    public class MorseViewTest
    {
        [Test]
        public void When_Pass_Args_To_Encoder_Works()
        {

            MorseViewController morseViewController = new MorseViewController([""]);

            morseViewController.PassDataToEncoder();
        }
    }
}
