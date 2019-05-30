using System.Collections.Generic;
using System.Linq;

namespace MorseEncoder
{
    public sealed class MorseEncoder
    {
        private static readonly Dictionary<char, string> MorseDictionary = new Dictionary<char, string>
        {
           {'a', ".-"},
           {'b', "-..."},
           {'c', "-.-."},
           {'d', "-.."},
           {'e', "."},
           {'f', "..-."},
           {'g', "--."},
           {'h', "...."},
           {'i', ".."},
           {'j', ".---"},
           {'k', "-.-"},
           {'l', ".-.."},
           {'m', "--"},
           {'n', "-."},
           {'o', "---"},
           {'p', ".--."},
           {'q', "--.-"},
           {'r', ".-."},
           {'s', "..."},
           {'t', "-"},
           {'u', "..-"},
           {'v', "...-"},
           {'w', ".--"},
           {'x', "-..-"},
           {'y', "-.--"},
           {'z', "--.."},
           {'0', "-----"},
           {'1', ".----"},
           {'2', "..---"},
           {'3', "...--"},
           {'4', "....-"},
           {'5', "....."},
           {'6', "-...."},
           {'7', "--..."},
           {'8', "---.."},
           {'9', "----."},
           { ' ', " " }
        };

        public string TextToMorse(string input)
        {
            string[] words = GetWordsFromInput(input);
            string[] morseArray = string.Join(" ", words)
                .Select(character => MorseDictionary[character] + "|").ToArray();
            string morseEncoded = string.Join("", morseArray);

            return morseEncoded;
        }

        private string[] GetWordsFromInput(string input)
            => input.ToLower().Split(' ').Where(word => word != string.Empty).ToArray();
    }
}
