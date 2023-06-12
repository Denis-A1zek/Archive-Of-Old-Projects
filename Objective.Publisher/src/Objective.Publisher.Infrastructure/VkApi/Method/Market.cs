using Objective.Publisher.Infrastructure.Common;
using Objective.Publisher.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.VkApi.Method
{
    public class Market
    {
        public async Task<IList<Item>> GetAllAsync()
        {
            var count = await GetCountAsync();
            return await Task.Run(() => Get(count));
        }

        public IList<Item> Get(int count)
        {
            string accessToken = $"https://api.vk.com/method/market.get?owner_id=-{VkApi.GroupId}&count={count}&access_token={VkApi.TOKEN}&v={VkApi.Version}";
            string data = VkApi.HttpClient.GetStringAsync(accessToken).Result;

            return JsonSerializer.Deserialize<MarketItem>(data).Response.Items;
        }

        private async Task<int> GetCountAsync()
        {
            return await Task.Run(() => GetCount());
        }

        private int GetCount()
        {
            string accessToken = $"https://api.vk.com/method/market.get?owner_id=-198486910&count=0&access_token={VkApi.TOKEN}&v={VkApi.Version}";

            string data = VkApi.HttpClient.GetStringAsync(accessToken).Result;

            var product = JsonSerializer.Deserialize<MarketItem>(data);

            return product.Response.Count;
        }
    }
}
