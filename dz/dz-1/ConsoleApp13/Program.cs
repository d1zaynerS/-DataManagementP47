using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Завдання 1");
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            Random rnd = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("A[" + i + "] = ");
                A[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = Math.Round(rnd.NextDouble() * 10, 2);
                }
            }

            Console.WriteLine("\nМасив A:");
            foreach (double x in A)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\nМасив B:");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine();
            }

            double max = Math.Max(A[0], B[0, 0]);
            double min = Math.Min(A[0], B[0, 0]);
            double sum = 0;
            double mult = 1;
            double sumEvenA = 0;
            double sumOddColB = 0;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max) max = A[i];
                if (A[i] < min) min = A[i];
                sum += A[i];
                mult *= A[i];
                if (A[i] % 2 == 0) sumEvenA += A[i];
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    double x = B[i, j];
                    if (x > max) max = x;
                    if (x < min) min = x;
                    sum += x;
                    mult *= x;
                    if (j % 2 == 1) sumOddColB += x;
                }
            }

            Console.WriteLine("\nМаксимум: " + max);
            Console.WriteLine("Мінімум: " + min);
            Console.WriteLine("Сума всіх: " + sum);
            Console.WriteLine("Добуток всіх: " + mult);
            Console.WriteLine("Сума парних елементів A: " + sumEvenA);
            Console.WriteLine("Сума непарних стовпців B: " + sumOddColB);
        }
    }
}
