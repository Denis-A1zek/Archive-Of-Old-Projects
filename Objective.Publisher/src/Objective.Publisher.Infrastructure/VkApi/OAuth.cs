using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.VkApi
{
    //https://oauth.vk.com/authorize?client_id=8163261&display=page&redirect_uri=https://vk.com/obelectronics&scope=wall%2Cmarket%2Cmanage%2Cphotos&response_type=token&v=5.131
    public class OAuth
    {
        private const string OAuthRedirectUrl = "https://oauth.vk.com/blank.html";
        private const string OAuthUrl = "https://oauth.vk.com/authorize";

        private string _clientId;

        public OAuth(string clientId)
        {
            _clientId = clientId;
        }

        public string GetAuthUrl()
        {
            return $"{OAuthUrl}?client_id={_clientId}&display=page&redirect_uri=https://vk.com/obelectronics&scope=wall%2Cmarket%2Cmanage&response_type=token&v=5.131";
        }
    }
}
