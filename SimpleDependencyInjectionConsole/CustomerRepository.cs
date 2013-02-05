using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace SimpleDependencyInjectionConsole
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly string _connection;

        public CustomerRepository(string connection)
        {
            _connection = connection;
        }

        public IEnumerable<Customer> GetAll()
        {
            using (var cn = new SqlConnection(_connection))
            {
                cn.Open();

                return cn.Query<Customer>("SELECT * FROM Customers");
            }
        }
    }
}