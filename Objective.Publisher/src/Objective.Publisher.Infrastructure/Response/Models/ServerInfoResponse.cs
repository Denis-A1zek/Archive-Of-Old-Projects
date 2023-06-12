using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class ServerInfoResponse
    {
        public ServerInfoResponse(int server, string photo, string hash)
        {
            Server=server;
            Photo=photo;
            Hash=hash;
        }

        [JsonProperty("server")]
        public int Server { get; set; }

        [JsonProperty("photo")]
        public string Photo { get; set; }

        [JsonProperty("hash")]
        public string Hash { get; set; }
    }
}
