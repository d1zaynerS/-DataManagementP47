using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть 4 цифри:"); 
            string num = ""; 
            for (int i = 0; i < 4; i++) num += Console.ReadLine(); 
            Console.WriteLine("Сформоване число: " + num);
        }
    }
}
