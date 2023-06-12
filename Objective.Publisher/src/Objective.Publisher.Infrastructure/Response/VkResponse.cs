using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Response
{
    public class VkResponse<T>
    {
        public VkResponse(T response)
        {
            Response=response;
        }

        [JsonProperty("response")]
        public T Response { get; set; }
    }
}
