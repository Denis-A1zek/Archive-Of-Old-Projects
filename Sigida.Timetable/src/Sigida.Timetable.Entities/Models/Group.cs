using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Sigida.Timetable.Entities.Models.Base;

namespace Sigida.Timetable.Entities.Models;

public class Group : EntityBase
{
    public Group() { }
    public Group(string name, ObjectId specialityId)
    {
        Name=name;
        SpecialityId=specialityId;
    }

    [BsonElement]
    public string Name { get; set; }

    [BsonElement]
    public DateTime Year { get; set; } 

    public int Course => DateTime.Now.Year - Year.Year + 1;

    [BsonElement]
    public ObjectId SpecialityId { get; set; }
}