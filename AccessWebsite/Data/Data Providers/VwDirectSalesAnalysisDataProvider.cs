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
    public interface IVwDirectSalesAnalysisDataProvider
    {
        public IEnumerable<VwDirectSalesAnalysis> getAnalyses();
        public VwDirectSalesAnalysis getAnalysis(int id);
    }

    public class VwDirectSalesAnalysisDataProvider : IVwDirectSalesAnalysisDataProvider
    {
        // DB:
        private readonly Website_AdvantageContext _db;
        public VwDirectSalesAnalysisDataProvider(Website_AdvantageContext db)
        {
            _db = db;
        }

        // Crud Methods:
        public IEnumerable<VwDirectSalesAnalysis> getAnalyses()
        {
            IEnumerable<VwDirectSalesAnalysis> analyses = _db.VwDirectSalesAnalyses;
            return analyses;
        }

        public VwDirectSalesAnalysis getAnalysis(int id)
        {
            VwDirectSalesAnalysis analysis = _db.VwDirectSalesAnalyses
                .First(s => s.DirectSalesOrderHeaderId == id);
            return analysis;
        }
    }
}
