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
    // Interface
    public interface IDirectSalesOrderStatusDataProvider
    {
        public IEnumerable<DirectSalesOrderStatus> getStatuses();
        public DirectSalesOrderStatus getStatus(string statusCode);
    }

    public class DirectSalesOrderStatusDataProvider : IDirectSalesOrderStatusDataProvider
    {
        // Dependency Injection
        private readonly Website_AdvantageContext _db;

        public DirectSalesOrderStatusDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<DirectSalesOrderStatus> getStatuses()
        {
            IEnumerable<DirectSalesOrderStatus> statuses = _db.DirectSalesOrderStatuses;
            return statuses;
        }

        public DirectSalesOrderStatus getStatus(string statusCode)
        {
            return _db.DirectSalesOrderStatuses.Find(statusCode); ;
        }

        // Add Status Code
    }
}
