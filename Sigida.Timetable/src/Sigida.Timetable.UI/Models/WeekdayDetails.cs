using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Models;

public class WeekdayDetails
{
    public WeekdayDetails(DayOfWeek dayOfWeek, IEnumerable<LessonDetails> lessons)
    {
        DayOfWeek=dayOfWeek;
        Lessons=lessons;
    }

    public DayOfWeek DayOfWeek { get; }
    public IEnumerable<LessonDetails> Lessons { get; }
}
