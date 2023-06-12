using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Converters;

public class LessoNumberToTimeConverter : IValueConverter
{
    private Dictionary<int, string> _numToTime = new Dictionary<int, string>
    {
        {1, "8:15" },
        {2, "9:45" },
        {3, "11:25" },
        {4, "13:45" },
        {5, "15:20" }
    };

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        return $"{NumberToTimeConvert((int)value)}";
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }

    private string NumberToTimeConvert(int num)
    {
        return _numToTime[num];
    }
}
