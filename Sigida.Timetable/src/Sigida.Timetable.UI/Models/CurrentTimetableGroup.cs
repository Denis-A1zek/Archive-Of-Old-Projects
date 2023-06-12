using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Models;

public class CurrentTimetableGroup
{
    public CurrentTimetableGroup(DayOfWeek dayOfWeek, string groupName, IEnumerable<LessonDetails> lessonsDetails)
    {
        DayOfWeek=dayOfWeek;
        GroupName=groupName;
        LessonsDetails=lessonsDetails;
    }

    public DayOfWeek DayOfWeek { get; }
    public string GroupName { get; }

    public IEnumerable<LessonDetails> LessonsDetails { get; }
}
