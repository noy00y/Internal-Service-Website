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
    public interface IProductReferenceDataProvider
    {
        public IEnumerable<ProductReference> getProductReferences();
        public ProductReference getProductReference(string partNumber);
    }

    public class ProductReferenceDataProvider : IProductReferenceDataProvider
    {
        // DB Injection:
        private readonly Website_AdvantageContext _db;
        
        public ProductReferenceDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductReference> getProductReferences()
        {
            IEnumerable<ProductReference> references = _db.ProductReferences;
            return references;
        }

        public ProductReference getProductReference(string partNumber)
        {
            return _db.ProductReferences.Find(partNumber);
        }
    }
}
