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


        [TestCase(new string[] {""}, "")]
        [TestCase(new string[] { "SOS" }, "...---...")]
        public void Given_Empty_String_Args(string[] input, string output)
        {
            ConsoleApp1.MorseViewController viewControl = new ConsoleApp1.MorseViewController(input);
            
            Assert.That(viewControl.PassDataToEncoder(), Is.EqualTo(output));
        }
    }
}
