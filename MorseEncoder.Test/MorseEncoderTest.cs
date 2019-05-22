using NUnit.Framework;

namespace MorseEncoder.Test
{
    [TestFixture]
    public sealed class MorseEncoderTest
    {

        /*
         * 
         */

        [TestCase("E", ".")]
        [TestCase("", "")]
        [TestCase("s", "...")]
        [TestCase("sos", "...---...")]
        [TestCase("hoLA", "....---.-...-")]
        public void Given_String_Return_Morse_Code(string input, string output)
        {
            MorseEncoder morseEncoder = new MorseEncoder();
            string morseCode = morseEncoder.TextToMorse(input);

            Assert.That(morseCode, Is.EqualTo(output));
        }

    }
}
