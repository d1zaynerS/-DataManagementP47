using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    internal class Program
    {
        // ================== Завдання 1 ==================
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        // ================== Завдання 2 ==================
        internal class SimplePriorityQueue
        {
            private int[] data = new int[100];
            private int count = 0;

            public int Count { get { return count; } }

            public void Enqueue(int item)
            {
                data[count++] = item;
                for (int i = 0; i < count - 1; i++)
                    for (int j = i + 1; j < count; j++)
                        if (data[i] < data[j])
                        {
                            int temp = data[i];
                            data[i] = data[j];
                            data[j] = temp;
                        }
            }

            public int Dequeue()
            {
                if (count == 0) 
                    throw new InvalidOperationException("Queue empty");
                int item = data[0];
                for (int i = 1; i < count; i++)
                    data[i - 1] = data[i];
                count--;
                return item;
            }
        }

        // ================== Завдання 3 ==================
        internal class SimpleCircularQueue<T>
        {
            private T[] buffer;
            private int head = 0;
            private int tail = 0;
            private int size = 0;

            public int Count { get { return size; } }

            public SimpleCircularQueue(int capacity)
            {
                buffer = new T[capacity];
            }

            public void Enqueue(T item)
            {
                if (size == buffer.Length) 
                    throw new InvalidOperationException("Queue full");
                buffer[tail] = item;
                tail = (tail + 1) % buffer.Length;
                size++;
            }

            public T Dequeue()
            {
                if (size == 0) 
                    throw new InvalidOperationException("Queue empty");
                T item = buffer[head];
                head = (head + 1) % buffer.Length;
                size--;
                return item;
            }
        }

        // ================== Завдання 4 ==================
        internal class SimpleSinglyList<T>
        {
            private T[] data = new T[100];
            private int count = 0;

            public int Count { get { return count; } }

            public void Add(T item)
            {
                if (count == data.Length) 
                    throw new InvalidOperationException("List full");
                data[count++] = item;
            }

            public void RemoveFirst()
            {
                if (count == 0) 
                    return;
                for (int i = 1; i < count; i++)
                    data[i - 1] = data[i];
                count--;
            }

            public void PrintAll()
            {
                for (int i = 0; i < count; i++)
                    Console.Write(data[i] + " ");
                Console.WriteLine();
            }
        }

        // ================== Завдання 5 ==================
        internal class SimpleDoublyList<T>
        {
            private T[] data = new T[100];
            private int count = 0;

            public int Count { get { return count; } }

            public void AddLast(T item)
            {
                if (count == data.Length) 
                    throw new InvalidOperationException("List full");
                data[count++] = item;
            }

            public void RemoveFirst()
            {
                if (count == 0) 
                    return;
                for (int i = 1; i < count; i++)
                    data[i - 1] = data[i];
                count--;
            }

            public void RemoveLast()
            {
                if (count > 0) 
                    count--;
            }

            public void PrintAllForward()
            {
                for (int i = 0; i < count; i++)
                    Console.Write(data[i] + " ");
                Console.WriteLine();
            }
        }

        // ================== Main ==================
        static void Main(string[] args)
        {

            // ====== Завдання 1 ======
            Console.WriteLine("\n--- Завдання 1 ---");
            int x = 5, y = 10;
            Console.WriteLine($"Перед Swap: x={x}, y={y}");
            Swap(ref x, ref y);
            Console.WriteLine($"Після Swap: x={x}, y={y}");

            // ====== Завдання 2 ======
            Console.WriteLine("\n--- Завдання 2 ---");
            SimplePriorityQueue pq = new SimplePriorityQueue();
            pq.Enqueue(5); pq.Enqueue(2); pq.Enqueue(8);
            while (pq.Count > 0)
                Console.Write(pq.Dequeue() + " ");
            Console.WriteLine();

            // ====== Завдання 3 ======
            Console.WriteLine("\n--- Завдання 3 ---");
            SimpleCircularQueue<string> cq = new SimpleCircularQueue<string>(3);
            cq.Enqueue("A"); cq.Enqueue("B"); cq.Enqueue("C");
            while (cq.Count > 0)
                Console.Write(cq.Dequeue() + " ");
            Console.WriteLine();

            // ====== Завдання 4 ======
            Console.WriteLine("\n--- Завдання 4  ---");
            SimpleSinglyList<int> sll = new SimpleSinglyList<int>();
            sll.Add(1); sll.Add(2); sll.Add(3);
            sll.PrintAll();
            sll.RemoveFirst();
            sll.PrintAll();

            // ====== Завдання 5 ======ы
            Console.WriteLine("\n--- Завдання 5 ---");
            SimpleDoublyList<int> dll = new SimpleDoublyList<int>();
            dll.AddLast(1); dll.AddLast(2); dll.AddLast(3);
            dll.PrintAllForward();
            dll.RemoveFirst(); dll.RemoveLast();
            dll.PrintAllForward();
        }
    }
}
