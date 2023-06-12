using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class MarketItem
    {
        public MarketItem(MarketItemsResponse response)
        {
            Response =response;
        }
        [JsonPropertyName("response")]
        public MarketItemsResponse Response { get; set; }
    }
}
