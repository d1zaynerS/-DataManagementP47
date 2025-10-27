using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть цифру словом (0-9): ");
            string input = Console.ReadLine().ToLower();

            int digit = WordToDigit(input);

            if (digit != -1)
                Console.WriteLine("Цифра: " + digit);
            else
                Console.WriteLine("Невідоме слово. Введіть число від zero до nine.");
        }

        public static int WordToDigit(string word)
        {
            if (word == "zero") 
                return 0;
            if (word == "one") 
                return 1;
            if (word == "two") 
                return 2;
            if (word == "three") 
                return 3;
            if (word == "four") 
                return 4;
            if (word == "five") 
                return 5;
            if (word == "six") 
                return 6;
            if (word == "seven") 
                return 7;
            if (word == "eight") 
                return 8;
            if (word == "nine") 
                return 9;

            return -1;
        }
    }
}
