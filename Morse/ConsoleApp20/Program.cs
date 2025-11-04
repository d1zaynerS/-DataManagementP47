using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp20;

namespace ConsoleApp20
{
    internal class MorseTranslator
    {
        private char[] _alphabet;
        private string[] _morseCodes;

        public MorseTranslator()
        {
            _alphabet = new char[] {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                'U', 'V', 'W', 'X', 'Y', 'Z',
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0',
                ' '
            };

            _morseCodes = new string[] {
                ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
                "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
                "..-", "...-", ".--", "-..-", "-.--", "--..",
                ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.", "-----",
                " / "
            };
        }

        public string ToMorse(string text)
        {
            string morseResult = "";

            foreach (char c in text)
            {
                char upperChar = char.ToUpper(c);

                for (int i = 0; i < _alphabet.Length; ++i)
                {
                    if (upperChar == _alphabet[i])
                    {
                        morseResult = morseResult + _morseCodes[i] + " ";
                        break;
                    }
                }
            }

            return morseResult.Trim();
        }
    }
}

namespace Module4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Morse Code Translator");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Enter text to translate:");

            string input = Console.ReadLine();

            if (!string.IsNullOrEmpty(input))
            {
                MorseTranslator translator = new MorseTranslator();

                string morseResult = translator.ToMorse(input);

                Console.WriteLine($"\nInput text: {input}");
                Console.WriteLine($"Morse code: {morseResult}");
            }
            else
            {
                Console.WriteLine("No input provided. Exiting.");
            }

            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadLine();
        }
    }
}