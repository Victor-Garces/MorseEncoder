using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace App.BDD
{
    [TestFixture]
    public class AppBTest
    {
        private static readonly string CurrentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void Given_Empty_String_Return_Empty()
        {
            using (Process sut = ReturnProcess(string.Empty))
            {
                sut.Start();

                string messageFromApp = sut.StandardOutput.ReadLine();

                Assert.That(messageFromApp, Is.Empty);
                Assert.That(sut.ExitCode, Is.Zero);
            }
        }

        private static Process ReturnProcess(string input)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    Arguments = input,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Path.Combine(@"C:\Users\Raul Caminero\Documents\MorseEncoder\MorseEncoder\ConsoleApp1\bin\Debug\", "ConsoleApp1.exe"),
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false
                }

            };

            return process;
        } 
    }
}
