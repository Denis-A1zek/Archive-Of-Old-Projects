using Objective.Publisher.Core;
using Objective.Publisher.Core.Models;
using Objective.Publisher.Infrastructure.VkApi;
using Objective.Publisher.Infrastructure.VkApi.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Objective.Publisher.App
{
    public class CommunityManager
    {
        private VkApi _vkApi;

        public CommunityManager()
        {
            _vkApi = new();

        }

        public async Task<IEnumerable<IMarketProduct>> GetProductFromMarketAsync()
        {
            return await Task.Run(() => GetProductFromMarket());

        }

        public  IEnumerable<IMarketProduct> GetProductFromMarket()
        {
            var products = _vkApi.Method<Market>().GetAllAsync().GetAwaiter().GetResult();

            List<IMarketProduct> marketProduct = new();

            foreach (var item in products)
            {
                marketProduct.Add(
                    new Product()
                    {
                        Id = item.Id,
                        Title = item.Title,
                        Description = item.Description,
                        PhotoUri = item.ThumbPhoto,
                        Price = 0
                    });
            }

            return marketProduct;
        }

        public async Task PostProductOnWallAsync(ProductPost post)
        {
            if (post is null)
                throw new ArgumentException();

            await Task.Run(() => PostProductOnWall(post));
        }

        public void PostProductOnWall(ProductPost post)
        {
            if (post is null)
                throw new ArgumentException();

            
        }

    }
}
