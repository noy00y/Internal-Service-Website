using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AccessWebsite.Models.Advantage;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace AccessWebsite.Data.Data_Providers
{
    // Interface:
    public interface ICustomerDataProvider
    {
        public IEnumerable<Customer> GetAllCustomers();
        public IList<Customer> GetCustomers(string searchString);
        public Customer GetCustomer(string CustomerCode);
    }

    // Interface Implementation
    public class CustomerDataProvider : ICustomerDataProvider
    {
        // Dependency Injection Constructor
        private readonly Website_AdvantageContext _db;
        public CustomerDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        // Crud Methods:
        public IEnumerable<Customer> GetAllCustomers()
        {
            IEnumerable<Customer> customers = _db.Customers;
            return customers;
        }

        public IList<Customer> GetCustomers(string searchString)
        {
            var customers = from c in _db.Customers
                            select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(s => s.CustomerName.Contains(searchString));
            }

            return customers.ToList();
        }

        public Customer GetCustomer(string CustomerCode)
        {
            Customer customer = _db.Customers
                .First(s => s.CustomerCode == CustomerCode);

            return customer;
        }
    }
}