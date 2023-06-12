using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Common.Models
{
    public class Size
    {
        public Size(int width, string url, string type, int height)
        {
            Width=width;
            Url=url;
            Type=type;
            Height=height;
        }

        [JsonProperty("width")]
        public int Width { get; set; }
        
        [JsonProperty("url")]
        public string Url { get; set; }
       
        [JsonProperty("type")]
        public string Type { get; set; }
        
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
