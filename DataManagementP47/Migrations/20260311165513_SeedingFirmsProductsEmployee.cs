using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataManagementP47.Migrations
{
    /// <inheritdoc />
    public partial class SeedingFirmsProductsEmployee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Birthdate", "FirmId", "Name" },
                values: new object[,]
                {
                    { new Guid("f1111111-1111-4111-8111-0000000000a1"), new DateTime(1985, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"), "Іваненко Петро" },
                    { new Guid("f2222222-2222-4222-8222-0000000000a2"), new DateTime(1990, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"), "Петренко Марія" },
                    { new Guid("f3333333-3333-4333-8333-0000000000a3"), new DateTime(1978, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"), "Сидоренко Олег" },
                    { new Guid("f4444444-4444-4444-8444-0000000000a4"), new DateTime(1995, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"), "Коваленко Анна" },
                    { new Guid("f5555555-5555-4555-8555-0000000000a5"), new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"), "Богданенко Роман" },
                    { new Guid("f6666666-6666-4666-8666-0000000000b6"), new DateTime(1987, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"), "Левченко Назар" },
                    { new Guid("f7777777-7777-4777-8777-0000000000b7"), new DateTime(1991, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"), "Мартинюк Оксана" },
                    { new Guid("f8888888-8888-4888-8888-0000000000b8"), new DateTime(1976, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"), "Проценко Ігор" },
                    { new Guid("f9999999-9999-4999-8999-0000000000b9"), new DateTime(1993, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"), "Демченко Лідія" },
                    { new Guid("fa0a0a0a-0a0a-4a0a-8a0a-0000000000ba"), new DateTime(1980, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"), "Гнатюк Василь" }
                });

            migrationBuilder.InsertData(
                table: "Firms",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"), "Novus Supplies LLC" },
                    { new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"), "Sunrise Components Ltd" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("aa111111-1111-4111-8111-0000000000a1"), "Кабель USB-C 1.5м Hoppe", 120m },
                    { new Guid("aa222222-2222-4222-8222-0000000000a2"), "SSD 256Gb Kingston A400", 900m },
                    { new Guid("aa333333-3333-4333-8333-0000000000a3"), "HDD SATA 2Tb Western Digital", 2200m },
                    { new Guid("aa444444-4444-4444-8444-0000000000a4"), "Миша оптична Logitech M90", 180m },
                    { new Guid("aa555555-5555-4555-8555-0000000000a5"), "Блок живлення 12V 5A MeanWell", 650m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f1111111-1111-4111-8111-0000000000a1"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f2222222-2222-4222-8222-0000000000a2"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f3333333-3333-4333-8333-0000000000a3"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f4444444-4444-4444-8444-0000000000a4"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f5555555-5555-4555-8555-0000000000a5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f6666666-6666-4666-8666-0000000000b6"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f7777777-7777-4777-8777-0000000000b7"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f8888888-8888-4888-8888-0000000000b8"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("f9999999-9999-4999-8999-0000000000b9"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: new Guid("fa0a0a0a-0a0a-4a0a-8a0a-0000000000ba"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("d1b2c3d4-e5f6-4711-9a2b-0000000000a1"));

            migrationBuilder.DeleteData(
                table: "Firms",
                keyColumn: "Id",
                keyValue: new Guid("e2c3d4e5-f6a7-4822-8b3c-0000000000b2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa111111-1111-4111-8111-0000000000a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa222222-2222-4222-8222-0000000000a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa333333-3333-4333-8333-0000000000a3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa444444-4444-4444-8444-0000000000a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aa555555-5555-4555-8555-0000000000a5"));
        }
    }
}
