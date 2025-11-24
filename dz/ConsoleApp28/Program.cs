using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    public delegate bool NumberCheck(int n);

    internal static class ArrayMethods
    {
        public static int[] GetNumbers(int[] data, NumberCheck check)
        {
            int count = 0;
            foreach (int x in data)
                if (check(x)) 
                    count++;

            int[] res = new int[count];
            int index = 0;
            foreach (int x in data)
                if (check(x)) 
                    res[index++] = x;

            return res;
        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        public static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        public static bool IsPrime(int n)
        {
            if (n < 2) 
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) 
                    return false;
            return true;
        }

        public static bool IsFibonacci(int n)
        {
            if (n == 0 || n == 1) 
                return true;
            int a = 0;
            int b = 1;
            while (b < n)
            {
                int temp = a + b;
                a = b;
                b = temp;
            }
            return b == n;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 8, 13, 21, 22, 23 };

            int[] even = ArrayMethods.GetNumbers(numbers, ArrayMethods.IsEven);
            int[] odd = ArrayMethods.GetNumbers(numbers, ArrayMethods.IsOdd);
            int[] prime = ArrayMethods.GetNumbers(numbers, ArrayMethods.IsPrime);
            int[] fib = ArrayMethods.GetNumbers(numbers, ArrayMethods.IsFibonacci);

            Console.Write("Even: ");
            foreach (int x in even) Console.Write(x + " ");
            Console.WriteLine();

            Console.Write("Odd: ");
            foreach (int x in odd) Console.Write(x + " ");
            Console.WriteLine();

            Console.Write("Prime: ");
            foreach (int x in prime) Console.Write(x + " ");
            Console.WriteLine();

            Console.Write("Fibonacci: ");
            foreach (int x in fib) Console.Write(x + " ");
            Console.WriteLine();
        }
    }
}


