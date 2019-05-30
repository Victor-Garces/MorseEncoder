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
        public void Given_Empty_String_Args(string[] input, string output)
        {
            string[] stringArray = new string[0];
            ConsoleApp1.MorseViewController viewControl = new ConsoleApp1.MorseViewController(stringArray);
           
            
            Assert.That(viewControl.PassDataToEncoder(), Is.EqualTo(output));
        }
    }
}
