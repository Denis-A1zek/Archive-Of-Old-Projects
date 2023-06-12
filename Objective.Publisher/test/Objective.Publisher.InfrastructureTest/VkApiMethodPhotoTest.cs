using Objective.Publisher.Infrastructure.VkApi;
using Objective.Publisher.Infrastructure.VkApi.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.InfrastructureTest
{
    internal class VkApiMethodPhotoTest
    {
        private VkApi vkApi;
        [SetUp]
        public void Setup()
        {
            vkApi = new();
        }

        [Test]
        public async Task GetWallUploadServerStringAsync_ShouldReturn_StringAndNotNull()
        {
            var photo = vkApi.Method<Photo>();

            var method = typeof(Photo).GetMethod(("GetWallUploadServerStringAsync"),
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            var result = await (Task<string>)method?.Invoke(photo, null);

            Assert.IsNotNull(result);
            Assert.IsNotEmpty(result);
        }

        [Test]
        public async Task GetPhotoFromServer_ShouldReturn_MultiPartContent()
        {
            var photo = vkApi.Method<Photo>();
            var marketItem = vkApi.Method<Market>().Get(1);

            var method = typeof(Photo).GetMethod(("GetPhotoFromServer"),
                BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);

            var result = await (Task<MultipartFormDataContent>)method?.Invoke(photo, new object[] { marketItem[0].ThumbPhoto, "photo" });

            Assert.IsNotNull(result);
        }

        [Test]
        public async Task UploadPhotoToServer_ServerId_ShouldBeen_IsNot0()
        {
            var photo = vkApi.Method<Photo>();
            var marketItem = vkApi.Method<Market>().Get(1);


            var result = await photo.UploadPhotoToServer(marketItem[0].ThumbPhoto);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Photo.Length > 10);
            Assert.IsTrue(result.Server > 0);
        }

        [Test]
        public async Task SaveWallPhoto_ServerRetrun_String()
        {
            var photo = vkApi.Method<Photo>();
            var marketItem = vkApi.Method<Market>().Get(1);


            var result = await photo.UploadPhotoToServer(marketItem[0].ThumbPhoto);
            var st = await photo.SaveWallPhoto(result);

            Assert.IsNotNull(st);
        }
    }
}
