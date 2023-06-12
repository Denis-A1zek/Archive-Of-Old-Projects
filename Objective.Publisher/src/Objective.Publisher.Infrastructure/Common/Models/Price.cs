using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Common
{
    public class Price
    {
        public Price(string amount, Currency currency, string text)
        {
            Amount=amount;
            Currency=currency;
            Text=text;
        }

        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        [JsonPropertyName("currency")]
        public Currency Currency { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
