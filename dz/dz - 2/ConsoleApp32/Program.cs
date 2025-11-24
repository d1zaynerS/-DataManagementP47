using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    internal class Program
    {
        static void Main(string[] args)
        {

            using (Magazin magazin1 = new Magazin("Світоч", "вул. Лесі Українки, 10", MagazinType.Prodovolchiy))
            {
                Console.WriteLine($"Назва: {magazin1.Name}");
                Console.WriteLine($"Адреса: {magazin1.Address}");
                Console.WriteLine($"Тип: {magazin1.Type}\n");
            }

            Console.WriteLine("Метод Dispose вызван для magazin1\n");

            Magazin magazin2 = new Magazin("Модна Хата", "вул. Центральна, 5", MagazinType.Odiah);
            Console.WriteLine($"Назва: {magazin2.Name}");
            Console.WriteLine($"Адреса: {magazin2.Address}");
            Console.WriteLine($"Тип: {magazin2.Type}\n");

            magazin2.Dispose();
            Console.WriteLine("Метод Dispose вызван для magazin2");
        }
    }

    internal enum MagazinType
    {
        Prodovolchiy,
        Hospodarskyi,
        Odiah,
        Vzuttya
    }

    internal class Magazin : IDisposable
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public MagazinType Type { get; set; }

        private bool disposed = false;

        public Magazin(string name, string address, MagazinType type)
        {
            Name = name;
            Address = address;
            Type = type;
        }

        public void Dispose()
        {
            if (!disposed)
            {
                Console.WriteLine($"Виконується Dispose для магазину: {Name}");
                disposed = true;
            }
        }
    }
}

