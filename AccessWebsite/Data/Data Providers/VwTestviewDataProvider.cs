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
    public interface IVwTestviewDataProvider
    {
        public IEnumerable<VwTestview> getTestViews();

        public VwTestview getTestView(int id);
    }

    public class VwTestviewDataProvider : IVwTestviewDataProvider
    {
        // DB:
        private readonly Website_AdvantageContext _db;
        public VwTestviewDataProvider (Website_AdvantageContext db)
        {
            _db = db;
        }

        public IEnumerable<VwTestview> getTestViews()
        {
            IEnumerable<VwTestview> testViews = _db.VwTestviews;
            return testViews;
        }

        public VwTestview getTestView(int id)
        {
            VwTestview testView = _db.VwTestviews
                .First(s => s.DirectSalesOrderHeaderId == id);

            return testView;
        }
    }
}
