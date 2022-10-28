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
    public interface IPriceHistoryDataProvider
    {
        public IEnumerable<ProductPriceHistory> getPriceHistories();
        public ProductPriceHistory getPriceHistory(string partNumber);
    }

    public class PriceHistoryDataProvider : IPriceHistoryDataProvider
    {
        // DB Injection:
        private readonly Website_AdvantageContext _db;

        public PriceHistoryDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductPriceHistory> getPriceHistories()
        {
            IEnumerable<ProductPriceHistory> histories = _db.ProductPriceHistories;
            return histories;
        }

        public ProductPriceHistory getPriceHistory(string partNumber)
        {
            return _db.ProductPriceHistories.Find(partNumber);
        }
    }
}
