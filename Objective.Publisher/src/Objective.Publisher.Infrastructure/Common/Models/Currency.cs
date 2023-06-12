using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Common
{
    public class Currency
    {
        public Currency(int id, string name, string title)
        {
            Id=id;
            Name=name;
            Title=title;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
