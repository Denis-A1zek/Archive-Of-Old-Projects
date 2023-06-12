using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class VkListResponse<T>
    {
        public VkListResponse(IList<T> response)
        {
            Response=response;
        }

        [JsonProperty("response")]
        public IList<T> Response { get; set; }
    }
}
