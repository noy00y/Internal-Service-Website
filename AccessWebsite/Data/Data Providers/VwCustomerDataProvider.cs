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
    public interface IVwCustomerDataProvdier 
    {
        public IEnumerable<VwCustomer> getVwCustomers();
        public VwCustomer getVwCustomer(string customerCode);
    }

    public class VwCustomerDataProvider : IVwCustomerDataProvdier
    {
        // DB Injection:
        private readonly Website_AdvantageContext _db;

        // Crud Methods:
        public VwCustomerDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<VwCustomer> getVwCustomers()
        {
            IEnumerable<VwCustomer> customers = _db.VwCustomers;
            return customers;
        }

        public VwCustomer getVwCustomer(string customerCode)
        {
            VwCustomer customer = _db.VwCustomers
                .First(s => s.CustomerCode == customerCode);

            return customer;
        }
    }
}
