using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_mongo.Repository
{
    public interface IRepository<T>
    {
        public Task<IEnumerable<T>> GetAll();
        public Task Add(T items);
        public Task AddMany(IEnumerable<T> items);
        public Task Update(T entity);
        public Task Delete(T entity);
        public Task DeleteMany(IEnumerable<T> entity);
        public Task<IEnumerable<T>> Find(Func<T,bool> predicat);
    }
}
