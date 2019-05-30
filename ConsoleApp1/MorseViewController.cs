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

            var encoded = encoder.TextToMorse(string.Join(" ", _args));

            return encoded;
        }

        public string CheckMaxFlag()
        {
            if (_args.Contains("-max"))
            {
                return int.TryParse(_args[Array.IndexOf(_args, "-max") + 1], out int number) ? number.ToString() : "Invalid max parameter";
            }

            return string.Empty;
        }

        public bool HasBeep()
        {
            return _args.Contains("-b");
        }
    }
}
