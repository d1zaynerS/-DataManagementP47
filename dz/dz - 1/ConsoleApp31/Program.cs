using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Piesa piesa1 = new Piesa("Гамлет", "Вільям Шекспір", "Трагедія", 1603);
            Piesa piesa2 = new Piesa("Лісова пісня", "Леся Українка", "Драма-феєрія", 1911);

            piesa1.PrintInfo();
            piesa2.PrintInfo();

            Console.WriteLine("\nУдаляем объект piesa1");
            piesa1 = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nОбъект piesa1 уничтожен (если сработал деструктор)");
        }
    }

    internal class Piesa
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        public Piesa(string name, string author, string genre, int year)
        {
            Name = name;
            Author = author;
            Genre = genre;
            Year = year;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Рік: {Year}\n");
        }

        ~Piesa()
        {
            Console.WriteLine($"Деструктор викликаний для п'єси: {Name}");
        }
    }
}

