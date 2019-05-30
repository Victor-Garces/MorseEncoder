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
        [TestCase(new string[] { "SOS" }, "...|---|...|")]
        public void Given_String_Args(string[] input, string output)
        {
            ConsoleApp1.MorseViewController viewControl = new ConsoleApp1.MorseViewController(input);
            
            Assert.That(viewControl.PassDataToEncoder(), Is.EqualTo(output));
        }

        [TestCase(new string[] { "SOS", "-max", "10" }, "10")]
        [TestCase(new string[] { "SOS", "-max", "aa" }, "Invalid max parameter")]
        [TestCase(new string[] { "SOS", "-max", "-b" }, "Invalid max parameter")]
        [TestCase(new string[] { "SOS"}, "")]
        public void Given_Flag_Max_String_Args(string[] input, string output)
        {
            ConsoleApp1.MorseViewController viewControl = new ConsoleApp1.MorseViewController(input);

            Assert.That(viewControl.CheckMaxFlag(), Is.EqualTo(output));
        }

        [TestCase(new string[] { "SOS", "-b" }, true)]
        [TestCase(new string[] { "SOS" }, false)]
        public void Given_Flag_b_String_Args(string[] input, bool output)
        {
            ConsoleApp1.MorseViewController viewControl = new ConsoleApp1.MorseViewController(input);

            Assert.That(viewControl.HasBeep(), Is.EqualTo(output));
        }
    }
}
