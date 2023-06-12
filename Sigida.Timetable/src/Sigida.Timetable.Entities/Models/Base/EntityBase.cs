using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Sigida.Timetable.Entities.Models.Base;

public class EntityBase
{
    [BsonId]
    public ObjectId Id { get; set; }
}
