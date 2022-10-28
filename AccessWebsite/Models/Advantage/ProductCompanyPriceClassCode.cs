using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class ProductCompanyPriceClassCode
    {
        public string ComputerizedPartNumber { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyPriceClassCode { get; set; }

        public virtual Product ComputerizedPartNumberNavigation { get; set; }
    }
}
