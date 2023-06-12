using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models.Base;


namespace Sigida.Timetable.Entities.Models;

public class Subject : EntityBase
{
    public Subject() { }

    public Subject(string name, SubjectType type, string lecture)
    {
        Name=name;
        Type=type;
        Lecture=lecture;
    }

    public string Name { get; set; }
    public SubjectType Type { get; set; }
    public string Lecture { get; set; }
}
