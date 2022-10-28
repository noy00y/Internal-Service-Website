using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class ProductReference
    {
        public string ProductReferenceGroupCode { get; set; }
        public string ProductReferenceCode { get; set; }
        public string ComputerizedPartNumber { get; set; }
        public string ProductReferenceTypeCode { get; set; }
        public decimal? UnitQuantity { get; set; }
        public decimal? CustomerUnitQuantity { get; set; }
        public string CustomerLabelName { get; set; }
    }
}
