


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Price
{
    public Price(decimal purchase, decimal sale)
    {
        Purchase=purchase;
        Sale=sale;
    }

    [BsonElement]
    public decimal Purchase { get; set; }
    [BsonElement]
    public decimal Sale { get; set; }

}
