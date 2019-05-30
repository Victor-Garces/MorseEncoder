using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorseEncoder;

namespace ConsoleApp1
{
    public sealed class MorseViewController
    {
        public string[] _args;

        public MorseViewController(string[] args)
        {
            _args = args;
        }

        public string PassDataToEncoder()
        {
            MorseEncoder.MorseEncoder encoder = new MorseEncoder.MorseEncoder();

            var encoded =  encoder.TextToMorse(string.Join(" ", _args));

            return encoded;
        }

    }
}
