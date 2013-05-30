using System.Collections.Generic;

namespace SimpleDependencyInjectionConsole
{
    public interface ICustomerRepository
    {
        Customer GetCustomer(string id);
        IEnumerable<Customer> GetAll();
    }
}