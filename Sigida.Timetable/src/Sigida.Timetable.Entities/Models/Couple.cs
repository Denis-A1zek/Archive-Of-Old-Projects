using MongoDB.Bson;

namespace Sigida.Timetable.Entities.Models;

public class Couple
{
    public Couple() { }

    public Couple(int num, ObjectId subjectId, string audience, bool onEven)
    {
        Num=num;
        SubjectId=subjectId;
        Audience=audience;
        OnEven=onEven;
    }

    public int Num { get; set; }
    public ObjectId SubjectId { get; set; }
    public string Audience { get; set; }
    public bool OnEven { get; set; }

}
