using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_mongo.Repository;
using test_mongo.Repository.Query;

namespace test_mongo.Service
{
    public class SupplyService
    {
        private readonly ProductProvider productProvider;
        private readonly SupplyProvider provider1;

        public SupplyService(ProductProvider provider, SupplyProvider provider1)
        {
            productProvider=provider;
            this.provider1=provider1;
        }

        public async Task Create(PurchaseRequisitionBuilder builder)
        {
            var supply = builder.Create();
            await productProvider.AddProductAsync(supply.Products);
            await provider1.AddAsync(supply.Supply);
        }

        public void Delete()
        {

        }

        public void Update()
        {

        }

        public void Find(ISearcher<Supply> searcher)
        {

        }
    }
}
