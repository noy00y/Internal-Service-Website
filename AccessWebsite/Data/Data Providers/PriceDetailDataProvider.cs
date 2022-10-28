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
    public interface IPriceDetailDataProvider
    {
        public IEnumerable<ProductPriceDetail> getPriceDetails();
        public ProductPriceDetail getPriceDetail(string productNumber);
    }

    public class PriceDetailDataProvider : IPriceDetailDataProvider
    {
        // DB Injection:
        private readonly Website_AdvantageContext _db;

        public PriceDetailDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductPriceDetail> getPriceDetails()
        {
            IEnumerable<ProductPriceDetail> priceDetails = _db.ProductPriceDetails;
            return priceDetails;
        }

        public ProductPriceDetail getPriceDetail(string productNumber)
        {
            return _db.ProductPriceDetails.Find(productNumber);
        }
    }
}
