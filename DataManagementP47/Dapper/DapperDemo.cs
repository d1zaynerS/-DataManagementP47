using Dapper;
using DataManagementP47.Ado.Orm;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataManagementP47.Dapper
{
    internal class DapperDemo
    {
        private SqlConnection? connection;
        public void Run()
        {
            Console.WriteLine("Dapper demo");
            OpenConnection();
            DapperAccessor accessor = new(connection!);

            //accessor.GetProducts().ForEach(firm => Console.WriteLine($"new Entities.Firm\r\n{{\r\nId = Guid.Parse(\"{firm.id}\"),\r\nName = \"{firm.Name}\"\r\n}});"));

            //Console.WriteLine(string.Join(",", accessor.GetProducts().Select(product =>
            //  $@"new Entities.Product 
            //  {{ 
            //       Id = Guid.Parse(""{product.Id}""), 
            //       Name = ""{product.Name}"", 
            //       Price = {product.Price}m 
            //  }}")));

            Console.WriteLine(String.Join(',', accessor.GetEmployees().Select(emp => $@"new Entities.Employee
                {{
                    Id = Guid.Parse(""{emp.Id}""),
                    FirmId = Guid.Parse(""{emp.FirmId}""),
                    Name = ""{emp.Name}"",
                    Birthdate = DateTime.Parse(""{emp.BirthDate:yyyy-MM-dd}"")
                }}")));

            Console.WriteLine(String.Join('\n', accessor.SearchProducts("USB")));
            Console.WriteLine($"Випадковий товар у БД: {accessor.RandomProduct()}");
            Console.WriteLine($"Випадковий фірма у БД: {accessor.RandomFirm()}");
        }
        private void OpenConnection()
        {
            // копія з Ado.cs
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
