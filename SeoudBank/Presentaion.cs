using SeoudBank.Entites.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using SeoudBank.BussniessLogic.IBussniess;
using SeoudBank.BussniessLogic;
using System.Text;
using System.Threading.Tasks;

namespace SeoudBank.Presenation
{
    static class CustomersPresentation
    {
        internal static void AddCustomer()
        {
            try
            {
                //create an object of Customer
                Customer customer = new Customer();

                //read all details from the user
                Console.WriteLine("\n********ADD CUSTOMER*************");
                Console.Write("Customer Name: ");
                customer.CustomerName = Console.ReadLine();
                Console.Write("Address: ");
                customer.Address = Console.ReadLine();
                Console.Write("Landmark: ");
                customer.LandMark = Console.ReadLine();
                Console.Write("City: ");
                customer.City = Console.ReadLine();
                Console.Write("Country: ");
                customer.Country = Console.ReadLine();
                Console.Write("Mobile: ");
                customer.Mobile = Console.ReadLine();

                //Create BL object
                ICustomerLogic customersBusinessLogicLayer = new CustomerLogic();
                Guid newGuid = customersBusinessLogicLayer.AddCustomer(customer);

                List<Customer> matchingCustomers = customersBusinessLogicLayer.GetCustomerWithCondition(item => item.CustomerID == newGuid);
                if (matchingCustomers.Count >= 1)
                {
                    Console.WriteLine("New Customer Code: " + matchingCustomers[0].CustomerCode);
                    Console.WriteLine("Customer Added.\n");
                }
                else
                {
                    Console.WriteLine("Customer Not added");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }


        internal static void ViewCustomers()
        {
            try
            {
                //Create BL object
                ICustomerLogic customersBusinessLogicLayer = new CustomerLogic();

                List<Customer> allCustomers = customersBusinessLogicLayer.GetCustomers();
                Console.WriteLine("\n**********ALL CUSTOMERS*************");
                //read all customers
                foreach (var item in allCustomers)
                {
                    Console.WriteLine("Customer Code: " + item.CustomerCode);
                    Console.WriteLine("Customer Name: " + item.CustomerName);
                    Console.WriteLine("Address: " + item.Address);
                    Console.WriteLine("Landmark: " + item.LandMark);
                    Console.WriteLine("City: " + item.City);
                    Console.WriteLine("Country: " + item.Country);
                    Console.WriteLine("Mobile: " + item.Mobile);
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.GetType());
            }
        }
    }
}
