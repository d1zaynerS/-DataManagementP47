using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1: квадрат");

            Console.Write("Введіть довжину сторони квадрата: ");
            int size = int.Parse(Console.ReadLine());

            Console.Write("Введіть символ для квадрата: ");
            char symbol = Console.ReadLine()[0];

            DrawSquare(size, symbol);
        }

        public static void DrawSquare(int side, char symbol)
        {
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }
    }
}
