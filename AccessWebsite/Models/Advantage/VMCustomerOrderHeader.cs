using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessWebsite.Models.Advantage
{
    public class VMCustomerOrderHeader
    {
        public Customer customer { get; set; }
        public IEnumerable<DirectSalesOrderHeader> orders { get; set; }
    }
}
