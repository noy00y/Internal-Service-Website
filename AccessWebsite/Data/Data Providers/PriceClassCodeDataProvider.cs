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
    public interface IPriceClassCodeDataProvider
    {
        public IEnumerable<ProductCompanyPriceClassCode> getPriceCodes();
    }

    public class PriceClassCodeDataProvider: IPriceClassCodeDataProvider
    {
        // DB Injection:
        private readonly Website_AdvantageContext _db;
        public PriceClassCodeDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductCompanyPriceClassCode> getPriceCodes()
        {
            IEnumerable<ProductCompanyPriceClassCode> priceCodes = _db.ProductCompanyPriceClassCodes;
            return priceCodes;
        }
    }
}
