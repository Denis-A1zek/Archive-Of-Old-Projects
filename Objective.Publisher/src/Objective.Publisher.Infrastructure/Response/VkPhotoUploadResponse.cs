using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class VkPhotoUploadResponse
    {
        public VkPhotoUploadResponse(PathPhotoResponse response)
        {
            Response=response;
        }

        [JsonProperty("response")]
        public PathPhotoResponse Response { get; set; }
    }
}
