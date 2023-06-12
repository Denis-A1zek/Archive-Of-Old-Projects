using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using test_mongo.Service;

namespace test_mongo.Repository
{
    public class SupplyRepository : IRepository<Supply>
    {
        private readonly ApplicationMongoContext context;

        public SupplyRepository(ApplicationMongoContext context)
        {
            this.context=context;
        }

        public async Task Add(Supply items)
        {
            await context.Supplys.InsertOneAsync(items);
        }

        public async Task AddMany(IEnumerable<Supply> items)
        {
            await context.Supplys.InsertManyAsync(items);
        }

        public async Task Delete(Supply entity)
        {
            await context.Supplys.DeleteOneAsync(x => x.Id == entity.Id);
        }

        public async Task DeleteMany(IEnumerable<Supply> entity)
        {
            var filter = Builders<Product>.Filter.In("Id", entity.Select(i => i.Id));
            await context.Products.DeleteManyAsync(filter);
        }

        public async Task<IEnumerable<Supply>> Find(Func<Supply, bool> predicat)
        {
            IEnumerable<Supply> result = null;
            using (var cursor = await context.Supplys.FindAsync(x => predicat(x)))
            {
                while (await cursor.MoveNextAsync())
                {
                    result = cursor.Current;
                }
            }

            if(result is null)
                return new List<Supply>();

            return result;
        }

        public async Task<IEnumerable<Supply>> GetAll()
        {
            IEnumerable<Supply> result = null;
            using (var cursor = await context.Supplys.FindAsync(x => true))
            {
                while(await cursor.MoveNextAsync())
                {
                    result = cursor.Current;
                }
            }

            if (result is null)
                return new List<Supply>();

            return result;
        }



        public async Task Update(Supply entity)
        {
            throw new NotImplementedException();
        }
    }
}
