using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mongo
{
    public class PurchaseRequisition
    {
        public Supply Supply { get; set; }
        public IEnumerable<Product> Products { get; set; }

        public IEnumerable<SupplyInfo> Info { get; set; }
    }
}
