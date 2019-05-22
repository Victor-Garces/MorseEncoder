using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Beeper.Beeper beep = new Beeper.Beeper(500);
            beep.Beep(3);
        }
    }
}
