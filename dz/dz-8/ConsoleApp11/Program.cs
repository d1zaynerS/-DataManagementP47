using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число для перевірки на Армстронга: "); 
            int arm = Convert.ToInt32(Console.ReadLine()); 
            int temp = arm; 
            int len = arm.ToString().Length; 
            int sum = 0;
            
            while (temp > 0) { 
                int dig = temp % 10; 
                sum += (int)Math.Pow(dig, len); 
                temp /= 10; 
            }
            Console.WriteLine(sum == arm ? "Число Армстронга" : "Не число Армстронга");
        }
    }
}
