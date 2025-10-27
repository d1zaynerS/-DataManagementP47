using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть перше число: "); 
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Введіть друге число: "); 
            int b = Convert.ToInt32(Console.ReadLine()); 
            if (a > b) 
                (a, b) = (b, a); 
            Console.WriteLine("Парні числа у діапазоні:"); 
            for (int i = a; i <= b; i++) 
                if (i % 2 == 0) 
                    Console.Write(i + " "); 
            Console.WriteLine();
        }
    }
}
