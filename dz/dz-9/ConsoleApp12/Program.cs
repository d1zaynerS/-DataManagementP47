using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть число для перевірки на досконалість: "); 

            int num2 = Convert.ToInt32(Console.ReadLine()); 
            int sumDiv = 0; 

            for (int i = 1; i < num2; i++) 
                if (num2 % i == 0) 
                    sumDiv += i; 
            Console.WriteLine(sumDiv == num2 ? "Досконале число" : "Не досконале число");
        }
    }
}
