using DataManagementP47.EF.Entities;
using System;
using System.Linq;

namespace DataManagementP47.EF
{
    internal class EfSearchHW
    {
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("=== ПОШУК СПІВРОБІТНИКІВ ===");
                Console.WriteLine("1 - Пошук за іменем");
                Console.WriteLine("2 - Пошук за віком");
                Console.WriteLine("0 - Вихід");
                Console.Write("Оберіть опцію: ");

                string choice = Console.ReadLine()!;

                if (choice == "0")
                {
                    Console.WriteLine("Програма завершена.");
                    break;
                }

                using (EfContext context = new())
                {
                    switch (choice)
                    {
                        case "1":
                            SearchByName(context);
                            break;
                        case "2":
                            SearchByAge(context);
                            break;
                        default:
                            Console.WriteLine("Невірний вибір. Спробуйте ще раз.");
                            break;
                    }
                }

                Console.WriteLine("\nНатисніть будь-яку клавішу для продовження...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private void SearchByName(EfContext context)
        {
            Console.Write("Введіть фрагмент імені для пошуку: ");
            string fragment = Console.ReadLine()!;

            if (string.IsNullOrWhiteSpace(fragment))
            {
                Console.WriteLine("Фрагмент імені не може бути порожнім.");
                return;
            }

            var employees = context.Employees
                .Where(e => e.Name.Contains(fragment))
                .ToList();

            Console.WriteLine($"\nРезультати пошуку за іменем, що містить '{fragment}':");

            if (employees.Count == 0)
            {
                Console.WriteLine("Співробітників не знайдено.");
                return;
            }

            Console.WriteLine($"Знайдено співробітників: {employees.Count}\n");

            for (int i = 0; i < employees.Count; i++)
            {
                var emp = employees[i];
                var today = DateTime.Today;
                int empAge = today.Year - emp.Birthdate.Year;
                if (emp.Birthdate.Date > today.AddYears(-empAge))
                {
                    empAge--;
                }

                Console.WriteLine($"{i + 1}. {emp.Name}, {emp.Birthdate:dd.MM.yyyy}, вік: {empAge}");
            }
        }

        private void SearchByAge(EfContext context)
        {
            Console.Write("Введіть вік для пошуку: ");
            if (!int.TryParse(Console.ReadLine(), out int targetAge))
            {
                Console.WriteLine("Некоректний вік. Введіть число.");
                return;
            }

            var employees = context.Employees
                .AsEnumerable()
                .Where(e =>
                {
                    var today = DateTime.Today;
                    int empAge = today.Year - e.Birthdate.Year;
                    if (e.Birthdate.Date > today.AddYears(-empAge))
                    {
                        empAge--;
                    }
                    return empAge == targetAge;
                })
                .ToList();

            Console.WriteLine($"\nРезультати пошуку за віком {targetAge}:");

            if (employees.Count == 0)
            {
                Console.WriteLine("Співробітників не знайдено.");
                return;
            }

            Console.WriteLine($"Знайдено співробітників: {employees.Count}\n");

            for (int i = 0; i < employees.Count; i++)
            {
                var emp = employees[i];
                Console.WriteLine($"{i + 1}. {emp.Name}, {emp.Birthdate:dd.MM.yyyy}");
            }
        }
    }
}
