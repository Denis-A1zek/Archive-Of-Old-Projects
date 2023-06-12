


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using test_mongo.Models;

public class Supply : EntityBase
{

    [BsonElement]
    public string? Provider { get; init; }

    [BsonElement]
    public List<SupplyInfo> Products { get; init; }

    [BsonElement]
    public DateTime DateOfDelivery { get; init; }

}
