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
    public interface IUnitMeasureDataProvider
    {
        public IEnumerable<ProductUnitOfMeasure> getMeasures();
    }

    public class UnitMeasureDataProvider : IUnitMeasureDataProvider
    {
        // DB Injection
        private readonly Website_AdvantageContext _db;
        public UnitMeasureDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<ProductUnitOfMeasure> getMeasures()
        {
            IEnumerable<ProductUnitOfMeasure> measures = _db.ProductUnitOfMeasures;
            return measures;
        }
    }
}
