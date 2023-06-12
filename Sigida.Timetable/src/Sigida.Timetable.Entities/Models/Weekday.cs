using Sigida.Timetable.Entities.Enums;

namespace Sigida.Timetable.Entities.Models;

public class Weekday
{
    public Weekday(WeekdayType day, List<Couple> couples)
    {
        Day=day;
        Couples=couples;
    }

    public WeekdayType Day { get; set; }
    public List<Couple> Couples { get; set; }

}
