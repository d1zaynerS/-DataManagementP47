using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: ");
            int number = int.Parse(Console.ReadLine());

            bool isPal = IsPalindrome(number);

            if (isPal)
                Console.WriteLine("Число " + number + " є паліндромом.");
            else
                Console.WriteLine("Число " + number + " НЕ є паліндромом.");
        }
        public static bool IsPalindrome(int num)
        {
            int original = num;
            int reverse = 0;

            while (num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num /= 10;
            }

            return original == reverse;
        }
    }
}
