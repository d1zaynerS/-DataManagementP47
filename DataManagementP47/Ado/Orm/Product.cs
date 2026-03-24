using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DataManagementP47.Ado.Orm
{
    internal class Product
    {
        public Guid Id { get; set; }
        public String Name { get; set; } = null!;

        public double Price { get; set; }

        public static Product FromReader(SqlDataReader reader)
        {
            return new Product
            {
                Id = reader.GetGuid("Id"),
                Name = reader.GetString("Name"),
                Price = Convert.ToDouble( reader.GetDecimal("Price"))
            };
        }
        public override string ToString()
        {
            String first3 = Id.ToString()[..3];
            String last3 = Id.ToString()[^3..];


            return $"{first3}..{last3} {Name}  ₴{Price:F2}";
        }
    }
}
/*
 * CREATE TABLE Products(
    Id    UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
    Name  NVARCHAR(256)    NOT NULL,
    Price MONEY            NOT NULL
);
 */