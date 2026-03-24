using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagementP47.Ado.Dal
{
    internal class DataAccessor(SqlConnection connection)
    {
        private SqlConnection _connection = connection;

        public int GetEmployeeCount()
        {
            return Convert.ToInt32(QueryScalar("SELECT COUNT(*) FROM Employees"));
        }

        public int GetProductCount()
        {
            return Convert.ToInt32(QueryScalar("SELECT COUNT(*) FROM Products"));
        }

        public DateTime GetFirstSaleMoment() => Convert.ToDateTime(QueryScalar("SELECT MIN(Moment) FROM Sales"));
        public DateTime GetLastSaleMoment() => Convert.ToDateTime(QueryScalar("SELECT MAX(Moment) FROM Sales"));

        public double GetAvgSale() => Convert.ToDouble(QueryScalar("SELECT AVG(S.Quantity * P.Price) FROM Sales S JOIN Products P ON S.ProductId = P.Id"));
        private object QueryScalar(String sql)
        {
            try
            {
                using SqlCommand command = new(sql, _connection);
                return command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException();
            }
        }
        public decimal GetMinSaleAmount() => Convert.ToDecimal(QueryScalar("SELECT MIN(S.Quantity * P.Price) FROM Sales S JOIN Products P ON S.ProductId = P.Id"));
        public decimal GetMaxSaleAmount() => Convert.ToDecimal(QueryScalar("SELECT MAX(S.Quantity * P.Price) FROM Sales S JOIN Products P ON S.ProductId = P.Id"));
        
        public int GetMaxProductsInSale() => Convert.ToInt32(QueryScalar("SELECT MAX(ProductCount) FROM (SELECT Id, SUM(Quantity) as ProductCount FROM Sales GROUP BY Id) as SaleProducts"));

        public (int MinEmployees, int MaxEmployees) GetMinMaxEmployees()
        {
            try
            {
                using SqlCommand command = new(@"
                          SELECT MIN(EmployeeCount), MAX(EmployeeCount)
                            FROM (
                                SELECT f.Id, COUNT(e.Id) AS EmployeeCount
                                FROM Firms f
                                LEFT JOIN Employees e ON e.FirmId = f.Id
                                GROUP BY f.Id
                                  ) AS FirmEmployees", _connection);
                using SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return (reader.IsDBNull(0) ? 0 : reader.GetInt32(0), reader.IsDBNull(1) ? 0 : reader.GetInt32(1));
                }
                else
                {
                    throw new InvalidOperationException("No data returned");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new InvalidOperationException();
            }
        }
    }
}
