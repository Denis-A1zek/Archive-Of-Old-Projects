using MongoDB.Bson;
using Sigida.Timetable.Data.Repository;
using Sigida.Timetable.Infrastructures.MongoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IMongoContext _context;
        private Dictionary<Type, object> _repository;

        public UnitOfWork(IMongoContext context)
        {
            _context=context;
        }

        public async Task<bool> Commit()
        {
            int changeAmmount;

            changeAmmount = await _context.SaveChangesAsync();

            return changeAmmount > 0;
        }


        public IRepository<TEntity, ObjectId> GetRepository<TEntity>()
        {
            if (_repository == null)
            {
                _repository = new();
            }

            var type = typeof(TEntity);
            if (!_repository.ContainsKey(type))
            {
                _repository[type] = new Repository<TEntity>(_context);
            }

            return (IRepository<TEntity, ObjectId>)_repository[type];
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
