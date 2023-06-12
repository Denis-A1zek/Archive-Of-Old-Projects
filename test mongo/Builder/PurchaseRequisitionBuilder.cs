

using test_mongo;

public class PurchaseRequisitionBuilder
{
    private List<SupplyInfo> supplyInfos;
    public List<Product> products;
    
    public PurchaseRequisitionBuilder()
    {
        supplyInfos = new List<SupplyInfo>();
        products = new();
    }

    public PurchaseRequisitionBuilder AddProductToSupply(Product product)
    {       
        products.Add(product);
        supplyInfos.Add(new SupplyInfo
        {
            Id = product.Id,
            Count = product.Count,
            Total = product.Price.Purchase
        });

        return this;
    }

    public PurchaseRequisition Create()
    {
        return new PurchaseRequisition()
        {
            Supply = new Supply
            {
                Provider = "Мелофон",
                Products = supplyInfos,
                DateOfDelivery = DateTime.Now
            },
            //Info не надо
            Info = supplyInfos,
            Products = products
        };
    }
}
