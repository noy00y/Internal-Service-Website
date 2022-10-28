using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class ProductDescription
    {
        public string ComputerizedPartNumber { get; set; }
        public string UnitOfMeasureTypeCode { get; set; }
        public string LanguageCode { get; set; }
        public string ProductName { get; set; }
        public string UnitOfMeasureCode { get; set; }

        public virtual Product ComputerizedPartNumberNavigation { get; set; }
    }
}
