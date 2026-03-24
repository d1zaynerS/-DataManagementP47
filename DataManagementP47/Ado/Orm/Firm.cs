using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DataManagementP47.Ado.Orm
{
    internal class Firm
    {
        public Guid Id { get; set; }
        public String Name { get; set; } = null!;

        public static Firm FromReader(SqlDataReader reader)
        {
            return new Firm
            {
                Id = reader.GetGuid("Id"),
                Name = reader.GetString("Name")
            };
        }

        public override string ToString()
        {
            String first3 = Id.ToString()[..3];
            String last3 = Id.ToString()[^3..];


            return $"{first3}..{last3} {Name}";
        }
    }
}
