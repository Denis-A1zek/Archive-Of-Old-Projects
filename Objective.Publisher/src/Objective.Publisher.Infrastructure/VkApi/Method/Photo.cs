
using Newtonsoft.Json;
using Objective.Publisher.Infrastructure.Response;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings;

namespace Objective.Publisher.Infrastructure.VkApi.Method
{
    public class Photo
    {
        public async Task<VkListResponse<PhotoResponse>> SaveWallPhoto(ServerInfoResponse response)
        {
            
            string responseString = $"https://api.vk.com/method/photos.saveWallPhoto?access_token={VkApi.TOKEN}" +
                                    $"&group_id={VkApi.GroupId}&photo={response.Photo}&server={response.Server}&hash={response.Hash}&v={VkApi.Version}";


            var data = await VkApi.HttpClient.GetStringAsync(responseString);
            return JsonConvert.DeserializeObject<VkListResponse<PhotoResponse>>(data);


        }

        public async Task<ServerInfoResponse> UploadPhotoToServer(string photoUrl)
        {
            var serverUpload = await GetWallUploadServerStringAsync();
            var image = await GetPhotoFromServer(photoUrl, $"photo");

            using(HttpClient client = new HttpClient())
            {
                var httpResponse = await client.PostAsync(serverUpload, image);
                var httpContent = await httpResponse.Content.ReadAsByteArrayAsync();

                string responseString = CodePagesEncodingProvider.Instance.GetEncoding(1251).GetString(httpContent, 0, httpContent.Length);
                return JsonConvert.DeserializeObject<ServerInfoResponse>(responseString);
            }
        }

        private async Task<string> GetWallUploadServerStringAsync()
        {
            var responseString = $"https://api.vk.com/method/photos.getWallUploadServer?access_token={VkApi.TOKEN}&group_id={VkApi.GroupId}&v={VkApi.Version}";
            var data = await VkApi.HttpClient.GetStringAsync(responseString);

            var response = JsonConvert.DeserializeObject<VkResponse<PathPhotoResponse>>(data);

            return response.Response.UploadUrl;                      
        }

        private async Task<MultipartFormDataContent> GetPhotoFromServer(string url, string parametrName)
        {
            using (WebClient client = new())
            {
                var data = await client.DownloadDataTaskAsync(url);
                var imageContent = new ByteArrayContent(data);

                var multipartContent = new MultipartFormDataContent();
                multipartContent.Add(imageContent, parametrName, "some.png");

                return multipartContent;
            }
        }

    }
}
