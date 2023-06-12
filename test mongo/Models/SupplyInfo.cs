


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class SupplyInfo
{

    [BsonElement]
    public ObjectId Id { get; set; }
    [BsonElement]
    public int Count { get; set; }

    [BsonElement]
    public decimal Total { get; set; }
}
