using Sigida.Timetable.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.Model;

public class SpecialtyDetails
{
    public SpecialtyDetails(string name, Dictionary<int, IEnumerable<Group>> groups)
    {
        Name=name;
        Groups=groups;
    }


    public string Name { get; set; }
    public Dictionary<int, IEnumerable<Group>> Groups { get; set; }


}
