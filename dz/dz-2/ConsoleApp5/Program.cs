using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число: "); 
            double val = Convert.ToDouble(Console.ReadLine()); 
            Console.Write("Введіть відсоток: "); 
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{p}% від {val} = {val * p / 100}");
        }
    }
}
