using MongoDB.Driver;

namespace Sigida.Timetable.Infrastructures.MongoDb;

public interface IMongoContext : IDisposable
{
    void AddCommand(Func<Task> command);
    Task<int> SaveChangesAsync();
    IMongoCollection<T> GetCollection<T>();
    void FromConnectionString(string connectionstring);
}

