using SeoudBank.Entites.Contracts;

namespace SeoudBank.DataAccess.IContext
{
    public interface ICustomerContext
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomerWithCondition(Predicate<Customer> customer);
        Guid AddCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(Guid customerId);
    }
}
