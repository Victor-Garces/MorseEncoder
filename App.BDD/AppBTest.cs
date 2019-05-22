using NUnit.Framework;
using System.Diagnostics;
using System.IO;

namespace App.BDD
{
    [TestFixture]
    public class AppBTest
    {
        private static readonly string CurrentDirectory = System.AppDomain.CurrentDomain.BaseDirectory;

        private static Process ReturnProcess(string input)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    Arguments = input,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = Path.Combine(CurrentDirectory, "App.exe"),
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
