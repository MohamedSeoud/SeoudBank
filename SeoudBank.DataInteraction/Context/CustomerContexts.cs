using SeoudBank.DataAccess.IContext;
using SeoudBank.Entites.Contracts;
using SeoudBank.Exceptions;

namespace SeoudBank.DataInteraction
{
    public class CustomerContexts : ICustomerContext
    {
        private List<Customer> _customers;
        public CustomerContexts()
        {
        Customers = new List<Customer>();
        }

        private List<Customer> Customers { get => _customers; set => _customers = value; }

        public Guid AddCustomer(Customer customer)
        {
            try
            {
            if (customer == null) throw new CustomerException("Customer is invaild");
            else
            {
                customer.CustomerID = Guid.NewGuid();
                Customers.Add(customer);
                return customer.CustomerID;
            }
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
            int isDeleted = Customers.RemoveAll(item => item.CustomerID == customerId);
            if (isDeleted > 0) return true;
            else throw new CustomerException("Customer Not Found");
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
            List<Customer> customerList = new List<Customer>();
            Customers.FindAll(customer).ForEach(item => {
                if (item == null) return;
                else customerList.Add(item.Clone() as Customer);
            });
            return customerList;
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
            List<Customer> customerList = new List<Customer>();
            Customers.ForEach(item=> {
                if (item == null) return;
                else customerList.Add(item.Clone() as Customer);});
            return customerList;
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
            var existingCustomer = Customers.Find(item => item.CustomerID == customer.CustomerID);
            if (existingCustomer != null)
            {
                existingCustomer.CustomerName = customer.CustomerName;
                existingCustomer.Mobile = customer.Mobile;
                existingCustomer.Country = customer.Country;
                existingCustomer.LandMark = customer.LandMark;
                existingCustomer.City = customer.City;   
                existingCustomer.Address = customer.Address;
                existingCustomer.CustomerCode = customer.CustomerCode;
                return true;
            }
            else
            {
                throw new CustomerException("Customer not found");
                return false;
            }
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