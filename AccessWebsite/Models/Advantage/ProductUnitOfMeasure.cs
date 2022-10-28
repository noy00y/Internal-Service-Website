using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class ProductUnitOfMeasure
    {
        public string ComputerizedPartNumber { get; set; }
        public string UnitOfMeasureTypeCode { get; set; }
        public decimal? UnitLength { get; set; }
        public decimal? UnitPriceAmount { get; set; }
    }
}
