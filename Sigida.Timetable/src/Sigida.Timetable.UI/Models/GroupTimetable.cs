using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Models;

public class GroupTimetable
{
    public string GroupName { get; }
    public IEnumerable<LessonDetails> Lessons { get; }
}
