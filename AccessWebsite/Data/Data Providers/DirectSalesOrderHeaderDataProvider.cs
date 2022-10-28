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
    public interface IDirectSalesOrderHeaderDataProvider
    {
        public IEnumerable<DirectSalesOrderHeader> getAllHeaders();

        public IEnumerable<DirectSalesOrderHeader> getHeaders(string CustomerCode);

        public DirectSalesOrderHeader getHeader(string headerID);
    }

    public class DirectSalesOrderHeaderDataProvider : IDirectSalesOrderHeaderDataProvider
    {
        // Dependency Injection
        private readonly Website_AdvantageContext _db;
        public DirectSalesOrderHeaderDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        // Crud Methods:

        public IEnumerable<DirectSalesOrderHeader> getAllHeaders()
        {
            IEnumerable<DirectSalesOrderHeader> orders = _db.DirectSalesOrderHeaders;
            return orders;
        }

        public IEnumerable<DirectSalesOrderHeader> getHeaders(string CustomerCode)
        {
            IEnumerable<DirectSalesOrderHeader> customerOrders = _db.DirectSalesOrderHeaders.Where(s => s.ShipToCustomerCode == CustomerCode);
            return customerOrders;
        }

        public DirectSalesOrderHeader getHeader(string headerID)
        {
            return _db.DirectSalesOrderHeaders.Find(headerID); 
        }
    }
}
