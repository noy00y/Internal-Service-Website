using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class PriceDisc
    {
        public string CompanyCode { get; set; }
        public string PriceListCode { get; set; }
        public string GenericCode { get; set; }
        public string MultiplierCode { get; set; }
        public decimal? Multiplier { get; set; }
    }
}
