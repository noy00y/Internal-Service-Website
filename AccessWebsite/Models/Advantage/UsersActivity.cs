using System;
using System.Collections.Generic;

#nullable disable

namespace AccessWebsite.Models.Advantage
{
    public partial class UsersActivity
    {
        public int DirectSalesOrderHeaderId { get; set; }
        public string Username { get; set; }
        public string StatusCode { get; set; }
        public string CompanyCode { get; set; }
        public string AgentCode { get; set; }
        public string ShipToCustomerCode { get; set; }
        public string WarehouseCode { get; set; }
        public string ReleaseNumber { get; set; }
        public DateTime? PurchaseOrderDate { get; set; }
        public string WaybillNumber { get; set; }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
