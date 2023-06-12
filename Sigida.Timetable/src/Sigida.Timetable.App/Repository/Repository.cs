using MongoDB.Bson;
using MongoDB.Driver;
using Sigida.Timetable.Infrastructures.MongoDb;
using System.Linq.Expressions;


namespace Sigida.Timetable.Data.Repository;

public class Repository<T> : IRepository<T, ObjectId>
{
    private readonly IMongoContext _context;
    private readonly IMongoCollection<T> _collection;

    public Repository(IMongoContext context)
    {
        _context=context;
        _collection = _context.GetCollection<T>();
    }
    public void Delete(ObjectId id)
    {
        _context.AddCommand(() => _collection.DeleteOneAsync(Builders<T>.Filter.Eq("_id", id)));
    }

    public async Task<bool> Exsist(T entity)
    {
        var allCollection = await FindAll();
        return allCollection.Contains(entity);
    }

    public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicat)
    {
        var data = await FindAll();
        return data.AsQueryable().Where(predicat);
    }

    public async Task<IEnumerable<T>> FindAll()
    {
        var all = await _collection.FindAsync(Builders<T>.Filter.Empty);
        return await all.ToListAsync();
    }

    public async Task<T> FindById(ObjectId id)
    {
        var data = await _collection.FindAsync(Builders<T>.Filter.Eq("_id", id));
        return data.SingleOrDefault();

    }

    public void Insert(T entity)
    {
        _context.AddCommand(() => _collection.InsertOneAsync(entity));
    }

    public void Update(T entity)
    {
        var id = entity.GetType().GetProperty("Id").GetValue(entity);
        _context.AddCommand(() => _collection.ReplaceOneAsync(Builders<T>.Filter.Eq("_id", id), entity));
    }
}
