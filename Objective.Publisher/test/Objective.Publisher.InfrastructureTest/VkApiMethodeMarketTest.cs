using Objective.Publisher.Infrastructure.VkApi;
using Objective.Publisher.Infrastructure.VkApi.Method;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.InfrastructureTest
{
    internal class VkApiMethodeMarketTest
    {
        private VkApi vkApi;
        [SetUp]
        public void Setup()
        {
            vkApi = new();
        }

        [Test]
        public async Task GetAllMethode_ShouldReturnProductsCount_MoteThen_0()
        {
            var products = await vkApi.Method<Market>().GetAllAsync();

            Assert.IsTrue(products.Count > 0);
        }
    }
}
