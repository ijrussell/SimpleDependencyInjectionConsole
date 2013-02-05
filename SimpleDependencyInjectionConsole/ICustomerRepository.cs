using System.Collections.Generic;

namespace SimpleDependencyInjectionConsole
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAll();
    }
}