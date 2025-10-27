using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 2");
            int[,] arr = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    arr[i, j] = rnd.Next(-100, 101);
                }
            }

            Console.WriteLine("Масив 5x5:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int minVal = arr[0, 0];
            int maxVal = arr[0, 0];
            int minIndex = 0;
            int maxIndex = 0;
            int index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (arr[i, j] < minVal) { minVal = arr[i, j]; minIndex = index; }
                    if (arr[i, j] > maxVal) { maxVal = arr[i, j]; maxIndex = index; }
                    index++;
                }
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);
            int sumBetween = 0;
            index = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (index > start && index < end) sumBetween += arr[i, j];
                    index++;
                }
            }

            Console.WriteLine("Мін: " + minVal + ", Макс: " + maxVal + ", Сума між ними: " + sumBetween);
        }
    }
}
