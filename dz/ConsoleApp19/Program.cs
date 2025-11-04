using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Book
    {
        public string Title { get; set; } = "Undefined";

        public Book(string title)
        {
            Title = title;
        }

        public override bool Equals(object obj)
        {
            if (obj is Book b)
                return Title == b.Title;
            return false;
        }

        public override int GetHashCode() => Title.GetHashCode();
        public static bool operator ==(Book b1, Book b2)
        {
            if (b1 is null && b2 is null)
                return true;
            if (b1 is null || b2 is null)
                return false;

            return b1.Title == b2.Title;
        }

        public static bool operator !=(Book b1, Book b2)
        {
            return !(b1 == b2);
        }
    }
    internal class ReadingList
    {
        private Book[] books;

        public ReadingList(int size)
        {
            books = new Book[size];
        }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                    return books[index];
                throw new IndexOutOfRangeException("Індекс за межами діапазону списку читання.");
            }
            set
            {
                if (index >= 0 && index < books.Length)
                    books[index] = value;
                else
                    throw new IndexOutOfRangeException("Індекс за межами діапазону списку читання.");
            }
        }

        public bool Contains(string title)
        {
            Book target = new Book(title);
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].Equals(target))
                    return true;
            }
            return false;
        }

        public void AddBook(Book book)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] == null)
                {
                    books[i] = book;
                    Console.WriteLine($"Книга '{book.Title}' додана.");
                    return;
                }
            }
            Console.WriteLine("Список переповнений!");
        }

        public void RemoveBook(string title)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null && books[i].Title == title)
                {
                    books[i] = null;
                    Console.WriteLine($"Книга '{title}' видалена.");
                    return;
                }
            }
            Console.WriteLine("Книгу не знайдено!");
        }

        public void ShowAll()
        {
            Console.WriteLine("\n Ваші книги у списку:");
            bool isEmpty = true;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i] != null)
                {
                    Console.WriteLine($"  {i + 1}. {books[i].Title}");
                    isEmpty = false;
                }
            }
            if (isEmpty)
            {
                Console.WriteLine("  Список порожній.");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadingList list = new ReadingList(5);
            int choice;
            string input;

            do
            {
                Console.WriteLine("\n--- Меню ---");
                Console.WriteLine("1 - Додати книгу");
                Console.WriteLine("2 - Видалити книгу");
                Console.WriteLine("3 - Перевірити наявність книги");
                Console.WriteLine("4 - Показати всі книги");
                Console.WriteLine("0 - Вихід");
                Console.Write("Ваш вибір: ");

                input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    choice = -1;
                    Console.WriteLine("Некоректний ввід. Будь ласка, введіть число.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введіть назву книги: ");
                        string addTitle = Console.ReadLine();
                        list.AddBook(new Book(addTitle));
                        break;
                    case 2:
                        Console.Write("Введіть назву книги для видалення: ");
                        string removeTitle = Console.ReadLine();
                        list.RemoveBook(removeTitle);
                        break;
                    case 3:
                        Console.Write("Введіть назву книги для перевірки: ");
                        string checkTitle = Console.ReadLine();
                        Console.WriteLine(list.Contains(checkTitle)
                            ? $"Книга '{checkTitle}' є у списку."
                            : $"Книги '{checkTitle}' немає у списку.");
                        break;
                    case 4:
                        list.ShowAll();
                        break;
                    case 0:
                        Console.WriteLine("Програма завершує роботу. До побачення!");
                        break;
                    default:
                        Console.WriteLine("Невідомий пункт меню. Спробуйте ще раз.");
                        break;
                }

            } while (choice != 0);
        }
    }
}
