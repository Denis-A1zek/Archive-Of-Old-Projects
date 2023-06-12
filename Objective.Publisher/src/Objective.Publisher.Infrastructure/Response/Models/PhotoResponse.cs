using Newtonsoft.Json;
using Objective.Publisher.Infrastructure.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class PhotoResponse
    {
        public PhotoResponse(int albumId, IList<Size> size, string date, int id, int ownerId, string accessKey, bool hasTags, string text)
        {
            AlbumId=albumId;
            Size=size;
            Date=date;
            Id=id;
            OwnerId=ownerId;
            AccessKey=accessKey;
            HasTags=hasTags;
            Text=text;
        }

        [JsonProperty("album_id")]
        public int AlbumId { get; set; }
        
        [JsonProperty("sizes")]
        public IList<Size> Size { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }

        [JsonProperty("access_key")]
        public string AccessKey { get; set; }

        [JsonProperty("has_tags")]
        public bool HasTags { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }


    }
}
