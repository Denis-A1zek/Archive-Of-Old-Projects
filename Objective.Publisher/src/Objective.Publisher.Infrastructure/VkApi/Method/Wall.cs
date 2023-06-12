using Objective.Publisher.Core;
using Objective.Publisher.Infrastructure.Common;
using Objective.Publisher.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.VkApi.Method
{
    public class Wall
    {
        public void Post(IMarketProduct item,PhotoResponse photo, double unixTime)
        {
            var message = $"{item.Title} \n\n {item.Description}";
            var method = $"https://api.vk.com/method/wall.post?owner_id=-198486910&from_group=1&message={message}" +
                         $"&attachments=market-198486910_{item.Id},photo{photo.OwnerId}_{photo.Id}&publish_date={unixTime}" +
                         $"&access_token={VkApi.TOKEN}&v={VkApi.Version}";

            WebClient webClient = new WebClient();
            var strings = webClient.DownloadString(method);
        }
    }
}
