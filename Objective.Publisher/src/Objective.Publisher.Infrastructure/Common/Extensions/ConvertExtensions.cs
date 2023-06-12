using Objective.Publisher.Core;
using Objective.Publisher.Infrastructure.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher
{
    public static class ConvertExtensions
    {
        public static IMarketProduct ToMarketProduct(this Item item)
        {
            var product = new Product()
            {
                Id = item.Id,
                Title = item.Title,
                Description = item.Description,
                PhotoUri = item.ThumbPhoto,
                Price =0
            };

            return product;
        }
    }
}
