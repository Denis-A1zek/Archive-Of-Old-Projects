using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Models;

public class LessonDetails
{
    public LessonDetails(int number, string name, string classroom, bool onEven)
    {
        Number=number;
        Name=name;
        Classroom=classroom;
        OnEven=onEven;
    }

    public int Number { get; }
    public string Name { get; }
    public string Classroom { get; }
    public bool OnEven { get; }
}
