using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI;

static class EvenWeek
{
    public static bool IsEven(this DateTime date)
    {
        var firstSeptember = GetStartDateOfTheYear();
        var numWeek = GetTheNumberOfWeeks(firstSeptember, date);
        return numWeek % 2 == 0;
    }

    private static DateTime GetStartDateOfTheYear()
    {
        return DateTime.Now.Month < 9 ? new DateTime(DateTime.Now.Year - 1, 9, 1) :
                                         new DateTime(DateTime.Now.Year, 9, 1);
    }

    private static double GetTheNumberOfWeeks(DateTime start, DateTime end)
    {
        return Math.Round((end - start).Days / 7.0);
    }

}
