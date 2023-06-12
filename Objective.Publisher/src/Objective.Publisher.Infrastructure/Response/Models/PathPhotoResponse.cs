using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class PathPhotoResponse
    {
        public PathPhotoResponse(string uploadUrl, int albumId, int userId)
        {
            UploadUrl=uploadUrl;
            AlbumId=albumId;
            UserId=userId;
        }

        [JsonProperty("upload_url")]
        public string UploadUrl { get; set; }
        
        [JsonProperty("album_id")]
        public int AlbumId { get; set; }
        
        [JsonProperty("user_id")]
        public int UserId { get; set; }
    }
}
