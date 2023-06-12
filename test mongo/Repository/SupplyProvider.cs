using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_mongo.Repository.Query;

namespace test_mongo.Repository
{
    public class SupplyProvider 
    {
        private SupplyRepository _repository;
        public SupplyProvider(SupplyRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Supply product)
        {
            CheckForNull(product);
            await _repository.Add(product);

        }

        public async Task AddAsync(IEnumerable<Supply> products)
        {
            CheckForNull(products);
            await _repository.AddMany(products);
        }

        public async Task DeleteAsync(Supply product)
        {
            CheckForNull(product);
            await _repository.Delete(product);
        }

        public async Task DeleteProductsAsync(IEnumerable<Supply> products)
        {
            CheckForNull(products);
            await _repository.DeleteMany(products);
        }

        public async Task UpdateAsync(Supply product)
        {
            CheckForNull(product);
            await _repository.Update(product);
        }

        public async Task<IEnumerable<Supply>> GetAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<Supply>> Find(ISearcher<Supply> searcher)
        {
            return await _repository.Find(searcher.Find());
        }

        private void CheckForNull(object? product)
        {
            if (product is null)
                throw new ProductWasNotFoundException($"{product} имеет значение null");
        }
    }
}
