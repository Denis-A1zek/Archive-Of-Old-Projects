using Objective.Publisher.Infrastructure.Common;
using Objective.Publisher.Infrastructure.VkApi.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.VkApi
{
    public  class VkApi
    {
        public VkApi()
        {
            HttpClient = new();
        }

        public const string TOKEN = "vk1.a.JBTpHSEy2bQBYU4mbUIP7G7hLMVhAbXwF-5Tl9rGfuTdW-s1xk9jxvESto7w1Ku0y2AYpk14tWL2h5ha1LOoO_2v2vQ9zkBvLE1Nricu_RxwMRp2wjGhWqgz2Au1WfKYF7Y076U1HqNpjx6kDwljRG31HZYjQXhuTNaYVzSIl9n70BdpSjLHbhRQXL6UFVaS";
        public const string Version = "5.131";
        public const string GroupId = "198486910";
        protected internal static HttpClient HttpClient { get; private set; }


        public T Method<T>()
        {
            var constructor = typeof(T).GetConstructor(new Type[] {});

            return (T)constructor?.Invoke(new Type[] { });
        }

        public static DateTime UnixTimeToDateTime(double unixTimeStamp) =>
            new DateTime(1970, 1, 1, 0, 0, 0, 0).AddSeconds(unixTimeStamp);

        public static double DateTimeToUnixTime(DateTime dateTime) =>
            dateTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
    }
}
