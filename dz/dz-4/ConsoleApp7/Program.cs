using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть шестизначне число: "); 
            string s = Console.ReadLine(); if (s.Length != 6) 
                Console.WriteLine("Помилка! Число не шестизначне."); 
            else { Console.Write("Введіть перший розряд для обміну: "); 
                int i1 = Convert.ToInt32(Console.ReadLine()) - 1; 
                Console.Write("Введіть другий розряд для обміну: "); 
                int i2 = Convert.ToInt32(Console.ReadLine()) - 1; 
                char[] arr = s.ToCharArray(); (arr[i1], arr[i2]) = (arr[i2], arr[i1]);
                Console.WriteLine("Результат: " + new string(arr)); }
        }
    }
}
