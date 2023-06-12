using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Sigida.Timetable.Entities.Models.Base;

namespace Sigida.Timetable.Entities.Models;

public class Faculty : EntityBase
{
    public Faculty() { }
    public Faculty(string name)
    {
        Name=name;
    }

    [BsonElement]
    public string Name { get; set; }

}
