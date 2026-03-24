using DataManagementP47.Ado.Dal;
using DataManagementP47.Ado.Orm;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;

namespace DataManagementP47.Ado
{
    public class Ado
    {
        // Перенесено до файлу конфігурації
        // String connectionString = @"....";
        
        private SqlConnection? connection;
        private record MenuData(char MenuChar, String MenuName, Action MenuAction);
        public void Run()
        {
            MenuData[] MenuItems = [
                new('1', "Перевірити підключення", OpenConnection),
                new('2', "Створити таблиці БД", CreateTables),
                new('3', "Заповнити початкові дані таблиці", InsertData),
                new('4', "Створити дані 1000 продажів", GenerateSales),
                new('5', "Вивесті дані про фірми", ShowFirms),
                new('6', "Статистика бази даних", Statistics),
                new('0', "Вихід", () => { })
            ];
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("ADO.NET");
            ConsoleKeyInfo keyInfo;
            do
            {
                foreach(var item in MenuItems)
                {
                    Console.WriteLine($"{item.MenuChar} - {item.MenuName}");
                }
                keyInfo = Console.ReadKey();
                Console.WriteLine();
                var selectedItem = MenuItems.FirstOrDefault(item => item.MenuChar == keyInfo.KeyChar);
                if (selectedItem != null)
                {
                    selectedItem.MenuAction();
                }
                else
                {
                    Console.WriteLine("Невірний вибір");
                }
            } while (keyInfo.KeyChar != '0');
        }
        //6
        private void Statistics()
        {
            if (connection is null)
            {
                Console.WriteLine("Підключення не встановлене, оберіть спочатку п.1");
                return;
            }
            DataAccessor dataAccessor = new(connection);
            try
            {
                Console.WriteLine($"Загальна кількість співробітників: {dataAccessor.GetEmployeeCount()}");
                Console.WriteLine($"Загальна кількість продуктів: {dataAccessor.GetProductCount()}");
                Console.WriteLine($"Момент початку продажів: {dataAccessor.GetFirstSaleMoment()}");
                Console.WriteLine($"Момент останньої продажі: {dataAccessor.GetLastSaleMoment()}");
                Console.WriteLine($"Середня сума продажу: {dataAccessor.GetAvgSale()}");
                Console.WriteLine("Для домашньої роботи:");
                Console.WriteLine($"Мінімальна сума чека: {dataAccessor.GetMinSaleAmount()}");
                Console.WriteLine($"Максимальна сума чека: {dataAccessor.GetMaxSaleAmount()}");
                Console.WriteLine($"Максимальна кількість товарів в одному чеку: {dataAccessor.GetMaxProductsInSale()}");
                var (minEmployees, maxEmployees) = dataAccessor.GetMinMaxEmployees();
                Console.WriteLine($"Мінімальна кількість співробітників у фірмі: {minEmployees}");
                Console.WriteLine($"Максимальна кількість співробітників у фірмі: {maxEmployees}");
                Console.WriteLine();
            }
            catch
            { 
                Console.WriteLine("Помилка при виконнані операцій");
            }
        }

        //4
        private void GenerateSales()
        {
            if(connection is null)
            {
                Console.WriteLine("Підключення не встановлене, оберіть спочатку п.1");
                return;
            } 
            List<Product> product = [];
            {
                using SqlCommand cmd1 = new("SELECT * FROM Products", connection);
                using SqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    product.Add(Product.FromReader(reader1));
                }
            }

            List<Employee> employees = [];
            {
                using SqlCommand cmd2 = new("SELECT * FROM Employees", connection);
                using SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    employees.Add(Employee.FromReader(reader2));
                }
            }

            Random random = new();
            String sql = "INSERT INTO Sales (Id, EmployeeId, ProductId, Quantity, Moment) " +
                               "VALUES( NEWID(), @EmployeeId, @ProductId, @Quantity, @Moment )";
            using SqlCommand cmd = new(sql, connection);
            
            SqlParameter employeeParam = new(){ParameterName = "@EmployeeId",DbType = DbType.Guid};
            cmd.Parameters.Add(employeeParam);
            
            SqlParameter productParam = new(){ ParameterName = "@ProductId",DbType = DbType.Guid};
            cmd.Parameters.Add(productParam);
            
            SqlParameter quantityParam = new(){ParameterName = "@Quantity", DbType = DbType.Int32 };
            cmd.Parameters.Add(quantityParam);

            SqlParameter momentParam = new(){ParameterName = "@Moment",DbType = DbType.DateTime2, Size = 7};
            cmd.Parameters.Add(momentParam);

            cmd.Prepare();

            for (int i = 0; i < 1000; i++)
            {
                Employee employee = employees[random.Next(employees.Count)];
                Product products = product[random.Next(product.Count)];
                int quantity = 1 + random.Next((int) (1000 / products.Price / 3));
                DateTime moment = DateTime.Now.AddSeconds(-random.Next(315360000));

                cmd.Parameters[0].Value = employee.Id;
                cmd.Parameters[1].Value = products.Id;
                cmd.Parameters[2].Value = quantity;
                cmd.Parameters[3].Value = moment;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Помилка: {ex.Message}");
                    return;
                }
            }

            int totalSales = 0;
            using (SqlCommand countCmd = new("SELECT COUNT(*) FROM Sales", connection))
            {
                totalSales = (int)countCmd.ExecuteScalar()!;
            }
            Console.WriteLine($"Команди виконано успішно, загальна кількість продажів: {totalSales}");
            /*Д.З Доповнити метод додавання (генерування) продажів:
             * наприкінці його роботи додати відомості про поточку кількість продажів:
             * - Команди виконано успішно, загальна кількість продажів: 3000
             */

        }
        private void ParametersInQuaries()
        {
            /* Параметрові запити
                        Передісторія: SQL-ін'єкції - спосіб включити до даних кода такб щоб вони виконались у запиті.
                        SELECT * FROM Users WHERE login ='{str}'
                        login > user
                        SELECT * FROM Users WHERE login ='user'
                        login>user' OR '1'='1
                        SELECT * FROM Users WHERE login ='user' OR '1'='1'
                        login>user'OR DROP TABLE Users =1
                        SELECT * FROM Users WHERE login ='user' OR DROP TABLE Users =1

                        2) Локалізація та національні символи
                            UPDATE Products SET Price ={x} WHERE Id ='1234124'
                            x = 99.50
                            з урахуванням української локалі число формується через кому 99.50 -> 99,50
                            UPDATE Products SET Price =99,50 WHERE Id ='1234124' -- помилка синтаксису

                        -Неможна "змішувати" код та дані, особливо якщо походження даних не є надійним(введеня
                            користувача, прийом з мережі, витяг з файлу тощо)
                        -Слід вживати заходи з відокремлення кодів та даних
                            SELECT * FROM Users WHERE login ='UTF_DECODE({str})'


                         !! Параметризовані запити - інструмент такого відокремлення: у запит включаються 
                             плейсхолдери - іменовані параметри, а окремо подаються їх значення, зазвичай,
                             із зазначенням типу даних.Синтаксис плейсхолдерів від сучасних технологій
                         */
            if (connection is null)
            {
                Console.WriteLine("Підключення не встановлене, оберіть спочатку п.1");
                return;
            }
            String sql = "SELECT * FROM Firms WHERE Name = @name";
            using SqlCommand cmd = new(sql, connection);
            SqlParameter nameParameter = new()
            {
                ParameterName = "@name",
                SqlDbType = SqlDbType.NVarChar,
                Value = "EcoResale JSC"
            };
            cmd.Parameters.Add(nameParameter);
            using SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Console.WriteLine("{0} {1}",
                    reader.GetGuid("Id"),
                    reader.GetString("Name"));
            }
            else
            {
                Console.WriteLine("Не знайдено");
            }
        }


        //5
        private void ShowFirms()
        {
            if (connection is null)
            {
                Console.WriteLine("Підключення не встановлене, оберіть спочатку п.1");
                return;
            }
            String sql = "SELECT * FROM Firms";
            using SqlCommand cmd = new(sql, connection);

            using SqlDataReader reader = cmd.ExecuteReader();
            //  while (reader.Read()) 
            //  { 
            //      Console.WriteLine("{0} {1}", 
            //          reader.GetGuid("Id"), 
            //          reader.GetString("Name"));
            //  }
            List<Firm> firms = [];
            while (reader.Read())
            {
                firms.Add(Firm.FromReader(reader));
            }
            foreach (Firm firm in firms)
            {
                Console.WriteLine(firm);
            }

        }
        //3
        private void InsertData()
        {
            if (connection is null)
            {
                Console.WriteLine("Підключення не встановлене, оберіть спочатку п.1");
                return;
            }
            String sql = File.ReadAllText(
                Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "sql/InsertData.sql"
            ));

            using SqlCommand cmd = new(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();   // виконання без повернення результату
                Console.WriteLine("Insert Data OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Insert Data fail: {ex.Message}");
                Console.WriteLine(sql);
            }
        }
        //2
        private void CreateTables()
        {
            if(connection is null)
            {
                Console.WriteLine("Підключення не встановлене, оберіть спочатку п.1");
                return;
            }

            // Другий етап - виконання команд (SQL-інструкцій)
            // Передача команд до СУБД та відповіді назад покладається
            // на SqlCommand
            // String sql = @"CREATE TABLE Firms(
            //    Id   UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
            //    Name NVARCHAR(64)     NOT NULL )";
            // команди є некерованими ресурсами, бажано вживати 
            // оператор автоматичного закриття - using//
            String sql = File.ReadAllText(
                Path.Combine(
                    Directory.GetCurrentDirectory(),
                    "sql/Tables.sql"
            ));
            // Команди також можуть виконуватись з файлу, у т.ч.
            // кілька команд, розділених ";"

            using SqlCommand cmd = new(sql, connection);
            try
            {
                cmd.ExecuteNonQuery();   // виконання без повернення результату
                Console.WriteLine("Create Tables OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Create Tables fail: {ex.Message}");
                Console.WriteLine(sql);
            }
        }

        //1
        private void OpenConnection()
        {
            // початок роботи з БД - підключення
            // традиція - рядок підключення - всі дані зібрані
            // до одного виразу
            String connectionString;
            try
            {
                var config = JsonSerializer.Deserialize<JsonElement>(
                    File.ReadAllText(
                        Path.Combine(
                            Directory.GetCurrentDirectory(),
                            "appsettings.json"
                        )
                    )
                );
                connectionString = config.GetProperty("ConnectionStrings").GetProperty("AdoDB").GetString()!;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Do you check appsettings.json?\n");
                return;
            }
            // управління підключенням забезпечує SqlConnection (Microsoft.Data.SqlClient)
            connection = new(connectionString);
            // однак, створення об'єкту не створює підключення (на відміну від
            //  багатьох аналогічних технологій)
            // Для активації підключення потрібно виконати команду Open
            try
            {
                connection.Open();
                Console.WriteLine("Connection OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection fail: {ex.Message}");
            }
        }
    }
}
/* ADO.NET - базова технологія доступу до даних платформи .NET :
додаємо бібліотеку (NuGet) з групи Microsoft.Data під обрану для
проєкту СУБД. Зокрема, для MS SQL Server це
Microsoft.Data.SqlClient

[Firms]   [Employee]    [Sales]        [Products]
Id --\    Id   ---\     Id           /- Id
Name  \-- FirmId   \--- EmployeeId  /   Name
          Name          ProductId -/    Price
          Birthday      Quantity   
                        Moment     

 */