using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.Model
{
    public class GroupTimetable
    {

        public GroupTimetable()
        {

            /*weekday = Timetable.Weekdays.Where(w => Convert.ToInt32(w.Day) == Convert.ToInt32(DateTime.Now.DayOfWeek)).FirstOrDefault();*/
           
        }

        public GroupTimetable(string name, IEnumerable<CoupleInfo> couples)
        {
            Name=name;
            Couples=couples;
        }

        public string Name { get; }
        public IEnumerable<CoupleInfo> Couples { get; }

    }
}
