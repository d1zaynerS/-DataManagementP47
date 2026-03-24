using Microsoft.Data.SqlClient;
using System.Data;
using System.Text;

namespace DataManagementP47.Ado.Orm
{
    internal class Employee
    {
        public Guid Id { get; set; }
        public Guid FirmId { get; set; }
        public DateTime BirthDate { get; set; }
        public String Name { get; set; } = null!;
        public static Employee FromReader(SqlDataReader reader)
        {
            return new Employee
            {
                Id = reader.GetGuid("Id"),
                FirmId = reader.GetGuid("FirmId"),
                Name = reader.GetString("Name"),
                BirthDate = reader.GetDateTime("BirthDate")
            };
        }
    }
}
