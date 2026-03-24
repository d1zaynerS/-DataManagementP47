using Dapper;
using DataManagementP47.Ado.Orm;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagementP47.Dapper
{
    internal class DapperAccessor(SqlConnection connection)
    {
        private readonly SqlConnection _connection = connection;

        public List<Product> GetProducts() => [.. 
            _connection.Query<Product>("SELECT * FROM Products")
        ];
        public List<Firm> GetFirms() => [..
            _connection.Query<Firm>("SELECT * FROM Firms")
        ];

        public List<Employee> GetEmployees() => [..
            _connection.Query<Employee>("SELECT * FROM Employees")
        ];
        public Product RandomProduct() => 
            _connection.QueryFirst<Product>("SELECT TOP 1 * FROM Products ORDER BY NEWID()");
        public Firm RandomFirm() =>
            _connection.QueryFirst<Firm>("SELECT TOP 1 * FROM Firms ORDER BY NEWID()");

        public List<Product> SearchProducts(String fragment) => [..
             _connection.Query<Product>("SELECT * FROM Products WHERE Name LIKE @fragment", new { fragment = $"%{fragment}%" })];
    }
}
