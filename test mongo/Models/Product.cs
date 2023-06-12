


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using test_mongo.Models;

public class Product : EntityBase, ICloneable
{
    public Product() { }
    public Product(string? barcode, string? vendorCode, ProductCategory productCategory, string name, Price price, int count)
    {
        Barcode=barcode;
        VendorCode=vendorCode;
        ProductCategory=productCategory;
        Name=name;
        Price=price;
        Count=count;
    }

    [BsonElement]
    public string? Barcode { get; set; }

    [BsonElement]
    public string? VendorCode { get; set; }

    [BsonElement]
    public ProductCategory ProductCategory { get; init; }

    [BsonElement]
    public string Name { get; set; }

    [BsonElement]
    public Price Price { get; init; }

    [BsonElement]
    public int Count { get; init; }

    public object Clone()
    {
        var newProduct = new Product(Barcode, VendorCode, ProductCategory, Name, new Price(Price.Purchase, Price.Sale), Count);
        newProduct.Id = Id;
        return newProduct;
    }

    public override bool Equals(object? obj)
    {
        var product = obj as Product;
        if(product != null)
        {
            return product.Barcode == Barcode && product.VendorCode ==
                    VendorCode && product.Name == Name && product.Price.Purchase == Price.Purchase;
        }
        return false;
    }

    public override string ToString()
    {
        return $"{Id}|{Name}";
    }

}
