using MongoDB.Driver;
using test_mongo.Repository;
using test_mongo.Service;

//"mongodb+srv://DenisA1z3K:hFtxmC4Uw2NeEAx@maincluster.x7yabqk.mongodb.net/?retryWrites=true&w=majority"

//Console.WriteLine("Введите логин");
//var login = Console.ReadLine();


//Console.WriteLine("Введите пароли");
//var password = Console.ReadLine();


var dbContext = new ApplicationMongoContext("mongodb+srv://DenisA1z3K:hFtxmC4Uw2NeEAx@maincluster.x7yabqk.mongodb.net/?retryWrites=true&w=majority");
ProductProvider pProvider = new ProductProvider(new ProductRepository(dbContext));
SupplyProvider sProvider = new SupplyProvider(new SupplyRepository(dbContext));

var supplyService = new SupplyService(pProvider, sProvider);

var listProduct = new List<Product>()
{
    new Product("1", "2", ProductCategory.Bluetooth, "Defender", new Price(500, 500), 5),
    new Product("2", "3", ProductCategory.Mobile, "SmartBuy", new Price(200, 400), 3)
};
//СНАЧАЛА ДОБАВИТЬ В БД ТОВАРЫ, А ПОТОМ ДОБАВЛЯТЬ ПОСТАВКУ

var collection = await pProvider.GetAsync();

var update = collection.FirstOrDefault();

var pro = dbContext.Products;

//pro.InsertOne(listProduct[0]);

var updatePro = collection.FirstOrDefault();
updatePro.Name = "FUS RO DAH";

var filter = Builders<Product>.Filter.Eq(x => x.Id, updatePro.Id);
var up = Builders<Product>.Update.Set(x => x.VendorCode, updatePro.VendorCode)
                                     .Set(x => x.Barcode, updatePro.Barcode)
                                     .Set(x => x.Name, updatePro.Name)
                                     .Set(x => x.ProductCategory, updatePro.ProductCategory)
                                     .Set(x => x.Count, updatePro.Count)
                                     .Set(x => x.Price, updatePro.Price);

var res = pro.UpdateOne(filter, up);

Console.WriteLine(res.ModifiedCount > 0);

//await pProvider.AddProductAsync(listProduct);
//var pBuilder = new PurchaseRequisitionBuilder().AddProductToSupply(listProduct[0]).AddProductToSupply(listProduct[1]);
//await sProvider.AddAsync(pBuilder.Create().Supply);


Console.ReadLine();

//public class CashBox : MongoContext
//{
//    private MongoContext _context;
//    private IMongoDatabase _database;
//    public CashBox(string connectionString) : base(connectionString)
//    {
//        _database = Client.GetDatabase("Objective");   
//    }

//    public Product FindProduct()
//    {
//        var collection = _database.GetCollection<Product>("Product");

//        var product = collection.Find(x => x.VendorCode == "123456789").ToList();

//        return product.FirstOrDefault();
//    }

//    public void GetDocument()
//    {
//        var database = Client.GetDatabase("Objective");
//        var dataList = Client.ListDatabases().ToList();

//        Console.WriteLine("The list of databases are:");

//        foreach (var item in dataList)
//        {
//            Console.WriteLine(item);
//        }
//    }

//    public void AddProducts()
//    {
//        var collections = _database.GetCollection<Product>("Product");

//        IEnumerable<Product> listProduct = new List<Product>
//        {
//            new Product("123456789", "Defender Gaming Mouse", new Price(500, 750)),
//            new Product("636556464", "SmartBuy Gaming Mouse", new Price(600, 850)),
//            new Product("765765765", "Jet.A Gaming Mouse", new Price(100, 350)),
//            new Product("867876867", "Reddragon Gaming Mouse", new Price(300, 350)),
//        };

//        var supBuilder = new SupplyBuilder();
//        collections.InsertMany(listProduct);

//        foreach (var item in listProduct)
//        {
//            supBuilder.AddProductToSupply(item, 3, 3);
//        }

//        AddDelivery(supBuilder.Create());
//    }

    

//    public void AddDelivery(Supply products)
//    {
//        var collections = _database.GetCollection<Supply>("Delivery");
       
//        collections.InsertOne(products);
//    }
//}
