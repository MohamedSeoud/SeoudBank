using SeoudBank.Entites.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeoudBank.BussniessLogic.IBussniess
{
    public interface ICustomerLogic
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomerWithCondition(Predicate<Customer> customer);
        Guid AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Guid customerId);
    }
}
