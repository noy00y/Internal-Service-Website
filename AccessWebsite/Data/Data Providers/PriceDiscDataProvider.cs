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
    public interface IPriceDiscDataProvider
    {
        public IEnumerable<PriceDisc> getDescriptions();
    }

    public class PriceDiscDataProvider : IPriceDiscDataProvider
    {
        // Dependency Injection:
        private readonly Website_AdvantageContext _db;

        public PriceDiscDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<PriceDisc> getDescriptions()
        {
            IEnumerable<PriceDisc> descriptions = _db.PriceDiscs;
            return descriptions;
        }
    }
}