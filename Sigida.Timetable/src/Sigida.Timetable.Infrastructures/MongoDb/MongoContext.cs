using MongoDB.Driver;

namespace Sigida.Timetable.Infrastructures.MongoDb;

public class MongoContext : IMongoContext
{
    private IMongoDatabase _database;
    private readonly List<Func<Task>> _commands;

    public MongoContext()
    {
        _commands = new List<Func<Task>>();
        FromConnectionString("4");
    }
    public MongoClient Client { get; private set; }
    public IClientSession Session { get; set; }

    public void AddCommand(Func<Task> command)
    {
        _commands.Add(command);
    }

    public IMongoCollection<T> GetCollection<T>()
    {
        //ConfigureMongo();

        var ctor = typeof(T).GetConstructor(new Type[] { });
        return _database.GetCollection<T>(ctor.DeclaringType.Name);
    }

    public async Task<int> SaveChangesAsync()
    {
        //ConfigureMongo();
        using (Session = await Client.StartSessionAsync())
        {
            Session.StartTransaction();
            var commandTask = _commands.Select(c => c());
            await Task.WhenAll(commandTask);
            await Session.CommitTransactionAsync();
        }

        var totalCommandsCompleted = _commands.Count;
        _commands.Clear();
        return totalCommandsCompleted;
    }


    public void Dispose()
    {
        Session?.Dispose();
        GC.SuppressFinalize(this);
    }
    public void FromConnectionString(string connectionstring)
    {
        if (Client != null)
        {
            return;
        }

        var settings = MongoClientSettings.FromConnectionString("mongodb://DenisA1z3K:hFtxmC4Uw2NeEAx@ac-zwdsufz-shard-00-00.x7yabqk.mongodb.net:27017,ac-zwdsufz-shard-00-01.x7yabqk.mongodb.net:27017,ac-zwdsufz-shard-00-02.x7yabqk.mongodb.net:27017/?ssl=true&replicaSet=atlas-edyv58-shard-0&authSource=admin&retryWrites=true&w=majority");
        settings.ServerApi = new ServerApi(ServerApiVersion.V1);
        Client = new MongoClient(settings);
        _database = Client.GetDatabase("Timetable");
    }
}
