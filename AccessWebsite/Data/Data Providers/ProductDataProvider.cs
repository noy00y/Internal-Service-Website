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

    public interface IProductDataProvider
    {
        public IEnumerable<Product> getProducts();
        public Product getProduct(string productCode);
    }

    public class ProductDataProvider : IProductDataProvider
    {
        // DB Injection
        private readonly Website_AdvantageContext _db;
        public ProductDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<Product> getProducts()
        {
            IEnumerable<Product> products = _db.Products;
            return products;
        }

        public Product getProduct(string productCode)
        {
            return _db.Products.Find(productCode);
        }
    }
}
