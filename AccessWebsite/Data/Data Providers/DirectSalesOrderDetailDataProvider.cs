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
    public interface IDirectSalesOrderDetailDataProvider
    {
        public IEnumerable<DirectSalesOrderDetail> getOrderDetails();
        public DirectSalesOrderDetail getOrderDetail(string detailsId);
    }

    public class DirectSalesOrderDetailDataProvider : IDirectSalesOrderDetailDataProvider
    {
        private readonly Website_AdvantageContext _db;
        public DirectSalesOrderDetailDataProvider (Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<DirectSalesOrderDetail> getOrderDetails()
        {
            IEnumerable<DirectSalesOrderDetail> orders = _db.DirectSalesOrderDetails;
            return orders;
        }

        public DirectSalesOrderDetail getOrderDetail(string detailsId)
        {
            return _db.DirectSalesOrderDetails.Find(detailsId);
        }
    }
}
