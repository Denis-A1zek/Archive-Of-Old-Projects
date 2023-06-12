using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Sigida.Timetable.Entities.Models.Base;


namespace Sigida.Timetable.Entities.Models;

public class Timetable : EntityBase
{
    public Timetable() { }
    public Timetable(ObjectId groupId, List<Weekday> weekdays)
    {
        GroupId=groupId;
        Weekdays=weekdays;
    }

    [BsonElement]
    public ObjectId GroupId { get; set; }

    [BsonElement]
    public List<Weekday> Weekdays { get; set; }
}
