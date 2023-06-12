using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Common
{
    public class Category
    {
        public Category(int id, string name, Section section)
        {
            Id=id;
            Name=name;
            Section=section;
        }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("section")]
        public Section Section { get; set; }
    }
}
