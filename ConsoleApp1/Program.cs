using ConsoleApp1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();

            MorseViewController MorseController = new MorseViewController(args);
            MorseController.PassDataToEncoder();
        }
    }
}
