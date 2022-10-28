using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessWebsite.Models.Advantage;
using AccessWebsite.Data.Data_Providers;

namespace AccessWebsite.Services
{
    public interface ICustomerService
    {
        public IList<Customer> GetCustomers(string searchString);
        public Customer GetCustomer(string CustomerCode);
    }

    // Interface Implementation
    public class CustomerService : ICustomerService
    {
        // DataProvider Injection
        public ICustomerDataProvider _customerDataProvider;

        public CustomerService(ICustomerDataProvider customerDataProvider)
        {
            _customerDataProvider = customerDataProvider;
        }

        public IList<Customer> GetCustomers(string searchString)
        {
            // If no searchString --> return empty list
            if (String.IsNullOrEmpty(searchString))
            {
                // temporary solution for no search string
                searchString = "askdjf;laksdjf;alksdjf";
            }

            IEnumerable<Customer> customers = _customerDataProvider.GetCustomers(searchString);
            return customers.ToList();
        }

        // GET: service/customer
        public Customer GetCustomer(string CustomerCode)
        {
            return _customerDataProvider.GetCustomer(CustomerCode);
        }

        // Service Methods

        // GET: Customer Orders

    }
}
