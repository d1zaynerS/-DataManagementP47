using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;

namespace DataManagementP47.Ado
{
    public class Ado
    {
        public async Task Run()
        {
            Console.WriteLine("--- Создание таблиц в Database1 ---");

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sergd\source\repos\HomeWork(1)\Database1.mdf;Integrated Security=True";

            using SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                await connection.OpenAsync();
                Console.WriteLine("Соединение успешно!");

                string dropSql = "DROP TABLE IF EXISTS Teachers; DROP TABLE IF EXISTS Groups; DROP TABLE IF EXISTS Departments; DROP TABLE IF EXISTS Faculties;";
                using (SqlCommand dropCmd = new SqlCommand(dropSql, connection))
                {
                    await dropCmd.ExecuteNonQueryAsync();
                }

                string[] queries = {
                    "CREATE TABLE Groups (Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, Name NVARCHAR(10) NOT NULL UNIQUE CHECK (Name <> ''), Rating INT NOT NULL CHECK (Rating BETWEEN 0 AND 5), Year INT NOT NULL CHECK (Year BETWEEN 1 AND 5))",
                    "CREATE TABLE Departments (Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, Financing MONEY NOT NULL DEFAULT 0 CHECK (Financing >= 0), Name NVARCHAR(100) NOT NULL UNIQUE CHECK (Name <> ''))",
                    "CREATE TABLE Faculties (Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, Name NVARCHAR(100) NOT NULL UNIQUE CHECK (Name <> ''))",
                    "CREATE TABLE Teachers (Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY, EmploymentDate DATE NOT NULL CHECK (EmploymentDate >= '1990-01-01'), Name NVARCHAR(MAX) NOT NULL CHECK (Name <> ''), Premium MONEY NOT NULL DEFAULT 0 CHECK (Premium >= 0), Salary MONEY NOT NULL CHECK (Salary > 0), Surname NVARCHAR(MAX) NOT NULL CHECK (Surname <> ''))"
                };

                foreach (var sql in queries)
                {
                    using SqlCommand cmd = new SqlCommand(sql, connection);
                    await cmd.ExecuteNonQueryAsync();
                    Console.WriteLine("Таблица создана!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }
    }
}