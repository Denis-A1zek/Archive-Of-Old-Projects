using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Objective.Publisher.Infrastructure.Common
{
    public class Item
    {
        public Item(int availability, Category category, string description, int id, int ownerID, Price price, string title, int date, string thumbPhoto, int cartQuantity)
        {
            Availability=availability;
            Category=category;
            Description=description;
            Id=id;
            OwnerID=ownerID;
            Price=price;
            Title=title;
            Date=date;
            ThumbPhoto=thumbPhoto;
            CartQuantity=cartQuantity;
        }

        [JsonPropertyName("availability")]
        public int Availability { get; set; }

        [JsonPropertyName("category")]
        public Category Category { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("owner_id")]
        public int OwnerID { get; set; }

        [JsonPropertyName("price")]
        public Price Price { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public int Date { get; set; }

        [JsonPropertyName("thumb_photo")]
        public string ThumbPhoto { get; set; }

        [JsonPropertyName("cart_quantity")]
        public int CartQuantity { get; set; }
    }
}
