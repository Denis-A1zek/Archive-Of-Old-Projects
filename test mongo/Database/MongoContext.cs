using MongoDB.Driver;

public class MongoContext
{
    public MongoContext(string connectionString)
    {
        CreateConnection(connectionString);
    }

    protected MongoClientSettings Settings { get; private set; }
    protected MongoClient Client { get; private set; }

    public void CreateConnection(string connectionString)
    {
        Settings = MongoClientSettings.FromConnectionString(connectionString);
        Settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        Client = new MongoClient(Settings);
    }
}
