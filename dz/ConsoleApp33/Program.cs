using System;
using System.IO;
using System.Text;

namespace Module11
{
    internal class Program
    {
        static bool IsPrime(int n)
        {
            if (n < 2) 
                return false;
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0) 
                    return false;
            return true;
        }

        static bool IsFib(int n)
        {
            if (n == 0 || n == 1) 
                return true;
            int a = 0;
            int b = 1;
            while (b < n)
            {
                int t = a + b;
                a = b;
                b = t;
            }
            return b == n;
        }

        static void Task1()
        {
            Console.WriteLine("Task 1:");

            Random r = new Random();
            int[] arr = new int[100];

            for (int i = 0; i < 100; i++)
                arr[i] = r.Next(0, 500);

            string primes = "";
            string fibs = "";

            for (int i = 0; i < 100; i++)
            {
                if (IsPrime(arr[i])) 
                    primes += arr[i] + "\n";
                if (IsFib(arr[i])) 
                    fibs += arr[i] + "\n";
            }

            using (FileStream stream = new FileStream("./primes.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                byte[] wbytes = Encoding.Default.GetBytes(primes);
                stream.Write(wbytes, 0, wbytes.Length);
            }

            using (FileStream stream = new FileStream("./fibs.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                byte[] wbytes = Encoding.Default.GetBytes(fibs);
                stream.Write(wbytes, 0, wbytes.Length);
            }

            Console.WriteLine("Saved primes.txt and fibs.txt");
        }

        static void Task2()
        {
            Console.WriteLine("\nTask 2:");

            Console.Write("Path: ");
            string path = Console.ReadLine();

            Console.Write("Find: ");
            string find = Console.ReadLine();

            Console.Write("Replace: ");
            string repl = Console.ReadLine();

            string text = "";

            using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
            {
                byte[] rbytes = new byte[stream.Length];
                stream.Read(rbytes, 0, rbytes.Length);
                text = Encoding.Default.GetString(rbytes);

                string result = "";
                for (int i = 0; i < text.Length;)
                {
                    bool match = true;
                    for (int j = 0; j < find.Length; j++)
                    {
                        if (i + j >= text.Length || text[i + j] != find[j])
                        {
                            match = false;
                            break;
                        }
                    }

                    if (match)
                    {
                        result += repl;
                        i += find.Length;
                    }
                    else
                    {
                        result += text[i];
                        i++;
                    }
                }

                stream.Seek(0, SeekOrigin.Begin);
                byte[] wbytes = Encoding.Default.GetBytes(result);
                stream.Write(wbytes, 0, wbytes.Length);
                stream.SetLength(wbytes.Length);
            }

            Console.WriteLine("Done.");
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
        }
    }
}


