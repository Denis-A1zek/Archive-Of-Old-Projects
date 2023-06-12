using MongoDB.Bson;
using MongoDB.Driver;

using Sigida.Timetable.Infrastructures.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity, ObjectId>
    {
        private readonly IMongoContext _context;
        private readonly IMongoCollection<TEntity> _collection;

        public Repository(IMongoContext context)
        {
            _context=context;

            _collection = context.GetCollection<TEntity>();
        }

        public void Delete(ObjectId id)
        {
            _context.AddCommand(async () =>
            {
                var opResult = await _collection.DeleteOneAsync(Builders<TEntity>.Filter.Eq("_id", id));
                if (opResult.DeletedCount == 0)
                    throw new Exception();
            });
        }

        public bool Exsist(TEntity entity)
        {
            var collection = FindAll();
            var searchedEntity = collection.Where(x => x.Equals(entity)).SingleOrDefault();
            return searchedEntity is not null;
        }

        public IReadOnlyCollection<TEntity> Find(Expression<Func<TEntity, bool>> predicat)
        {
            return _collection.Find(predicat).ToList();
        }

        public IReadOnlyCollection<TEntity> FindAll()
        {

            return Find(x => true);
        }

        public TEntity FindById(ObjectId id)
        {
            var collection = _collection.Find(Builders<TEntity>.Filter.Eq("_id", id)).SingleOrDefault();
            return collection;
        }

        public void Insert(TEntity entity)
        {
            _context.AddCommand(() => _collection.InsertOneAsync(entity));
        }

        public void Update(TEntity entity)
        {
            var id = entity.GetType().GetProperty("Id").GetValue(entity);
            _context.AddCommand(() => _collection.ReplaceOneAsync(Builders<TEntity>.Filter.Eq("_id", id), entity));
        }
    }
}
