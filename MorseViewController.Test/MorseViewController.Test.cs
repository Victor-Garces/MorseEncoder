using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ConsoleApp1;

namespace MorseViewController.Test
{
    [TestFixture]
    public sealed class MorseViewTest
    {


        [TestCase("", "")]
        public void Given_Empty_String_Args(string input, string output)
        {
            String[] stringArray = new String[0];
            ConsoleApp1.MorseViewController viewControl = new ConsoleApp1.MorseViewController(stringArray);
            viewControl.PassDataToEncoder();
            
            Assert.That(morseCode, Is.EqualTo(output));
        }
    }
}
