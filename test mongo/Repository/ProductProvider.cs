using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_mongo.Repository.Query;

namespace test_mongo.Repository
{
    public class ProductProvider
    {
        private ProductRepository _repository;
        public ProductProvider(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task AddAsync(Product product)
        {
            CheckForNull(product);
            await _repository.Add(product);

        }

        public async Task AddProductAsync(IEnumerable<Product> products)
        {
            CheckForNull(products);
            await _repository.AddMany(products);
        }

        public async Task DeleteAsync(Product product)
        {
            CheckForNull(product);
            await _repository.Delete(product);
        }

        public async Task DeleteProductsAsync(IEnumerable<Product> products)
        {
            CheckForNull(products);
            await _repository.DeleteMany(products);
        }

        public async Task UpdateAsync(Product product)
        {
            CheckForNull(product);
            await _repository.Update(product);
        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            return await _repository.GetAll();
        }

        public async Task<IEnumerable<Product>> Find(ISearcher<Product> searcher)
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
