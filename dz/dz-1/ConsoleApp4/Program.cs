using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число від 1 до 100: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 100)
                Console.WriteLine("Помилка! Число має бути в діапазоні 1–100.");
            else if (n % 3 == 0 && n % 5 == 0)
                Console.WriteLine("Fizz Buzz");
            else if (n % 3 == 0)
                Console.WriteLine("Fizz");
            else if (n % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(n);
        }
    }
}
