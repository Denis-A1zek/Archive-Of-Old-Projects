using MongoDB.Bson;
using Sigida.Timetable.UI.Common.Interfaces;

namespace Sigida.Timetable.UI.Common;

public struct SpecialtyQuery
{
    public SpecialtyQuery(ObjectId id, string name, int course)
    {
        Id=id;
        Name=name;
        Course=course;
    }

    public ObjectId Id { get; }
    public string Name { get; }
    public int Course { get; }
}


