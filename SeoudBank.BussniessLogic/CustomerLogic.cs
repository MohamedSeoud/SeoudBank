using SeoudBank.BussniessLogic.IBussniess;
using SeoudBank.DataAccess.IContext;
using SeoudBank.DataInteraction;
using SeoudBank.Entites.Contracts;
using SeoudBank.Exceptions;

namespace SeoudBank.BussniessLogic
{
    public class CustomerLogic : ICustomerLogic
    {
        private ICustomerContext _customerContext;
        public CustomerLogic()
        {
            _customerContext = new CustomerContexts();
        }
        private ICustomerContext CustomerContext { get => _customerContext; set => _customerContext = value; }

        public Guid AddCustomer(Customer customer)
        {
            try
            {
               List<Customer> customerList = CustomerContext.GetCustomers();

                if (customerList.Count == 0)
                {
                    customer.CustomerCode = SeoudBank.Configuration.Settings.BaseCustomerNumber + 1;
                }
                else
                {
                    long max = 1001;
                    customerList.ForEach(item =>
                    {
                        if (item.CustomerCode > max) max = item.CustomerCode;
                    });
                    customer.CustomerCode = max;
                }
                return CustomerContext.AddCustomer(customer);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool DeleteCustomer(Guid customerId)
        {
            try
            {
                return CustomerContext.DeleteCustomer(customerId);
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Customer> GetCustomers()
        {
            try
            {
                return CustomerContext.GetCustomers();
            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Customer> GetCustomerWithCondition(Predicate<Customer> customer)
        {
            try
            {
                return CustomerContext.GetCustomerWithCondition(customer);

            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateCustomer(Customer customer)
        {
            try
            {
                return CustomerContext.UpdateCustomer(customer);

            }
            catch (CustomerException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}