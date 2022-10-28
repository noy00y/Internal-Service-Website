using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class VwDirectSalesAnalysis
    {
        public int DirectSalesOrderHeaderId { get; set; }
        public string CompanyCode { get; set; }
        public string AgentCode { get; set; }
        public int? YearCreated { get; set; }
        public int? MonthCreated { get; set; }
        public int? NumberOfLineItems { get; set; }
        public decimal? TotalAmount { get; set; }
    }
}
