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
    public interface IProductDescriptionDataProvider
    {
        public IEnumerable<ProductDescription> getDescriptions();
        public ProductDescription getDescription(string partNumber);
    }

    public class ProductDescriptionDataProvider : IProductDescriptionDataProvider
    {
        // Db Injection:
        private readonly Website_AdvantageContext _db;
        
        public ProductDescriptionDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductDescription> getDescriptions()
        {
            IEnumerable<ProductDescription> descriptions = _db.ProductDescriptions;
            return descriptions;
        }

        public ProductDescription getDescription(string productCode)
        {
            return _db.ProductDescriptions.Find(productCode);
        }
    }
}
