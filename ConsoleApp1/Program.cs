using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MorseViewController viewController = new MorseViewController(args);
            var messageEncoded = viewController.PassDataToEncoder();
            Console.WriteLine(messageEncoded);
        }
    }
}
