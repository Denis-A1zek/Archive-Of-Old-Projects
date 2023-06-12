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
    public class ProductRepository : IRepository<Product>
    {
        private readonly ApplicationMongoContext context;

        public ProductRepository(ApplicationMongoContext context)
        {
            this.context=context;
        }

        public async Task Add(Product items)
        {
            await context.Products.InsertOneAsync(items);
        }

        public async Task AddMany(IEnumerable<Product> items)
        {
            await context.Products.InsertManyAsync(items);
        }

        public async Task Delete(Product entity)
        {
            await context.Products.DeleteOneAsync(x => x.Id == entity.Id);
        }

        public async Task DeleteMany(IEnumerable<Product> entity)
        {
            var filter = Builders<Product>.Filter.In("Id", entity.Select(i => i.Id));
            await context.Products.DeleteManyAsync(filter);
        }

        public async Task<IEnumerable<Product>> Find(Func<Product, bool> predicat)
        {
            IEnumerable<Product> result = null;
            using (var cursor = await context.Products.FindAsync(x => predicat(x)))
            {
                while (await cursor.MoveNextAsync())
                {
                    result = cursor.Current;
                }
            }

            if(result is null)
                return new List<Product>();

            return result;
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            IEnumerable<Product> result = null;
            using (var cursor = await context.Products.FindAsync(x => true))
            {
                while(await cursor.MoveNextAsync())
                {
                    result = cursor.Current;
                }
            }

            if (result is null)
                return new List<Product>();

            return result;
        }



        public async Task Update(Product entity)
        {
            var filter = Builders<Product>.Filter.Eq(x => x.Id, entity.Id);
            var update = Builders<Product>.Update.Set(x => x.VendorCode, entity.VendorCode)
                                                    .Set(x => x.Barcode, entity.Barcode)
                                                        .Set(x => x.Name, entity.Name)
                                                            .Set(x => x.ProductCategory, entity.ProductCategory)
                                                                .Set(x => x.Count, entity.Count)
                                                                    .Set(x => x.Price, entity.Price);

            context.Products.UpdateOne(filter, update);
        }
    }
}
