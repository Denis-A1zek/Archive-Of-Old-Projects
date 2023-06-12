using Objective.Publisher.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class MarketItemsResponse
    {
        public MarketItemsResponse(int count, IList<Item> items)
        {
            Count = count;
            Items = items;
        }
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("items")]
        public IList<Item> Items { get; set; }
    }
}
