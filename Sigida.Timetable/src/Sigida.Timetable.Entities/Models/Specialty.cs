using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Sigida.Timetable.Entities.Models.Base;


namespace Sigida.Timetable.Entities.Models;

public class Specialty : EntityBase
{
    public Specialty() { }
    public Specialty(string name, ObjectId facultyId)
    {
        Name=name;
        FacultyId=facultyId;
    }

    [BsonElement]
    public string Name { get; set; }

    [BsonElement]
    public ObjectId FacultyId { get; set; }

}
