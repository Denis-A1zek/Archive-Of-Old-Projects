using Sigida.Timetable.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Models;

public class FacultyDetails
{
    public FacultyDetails(Faculty faculty, IEnumerable<Specialty> specialties)
    {
        Faculty=faculty;
        Specialties=specialties;
    }

    public Faculty Faculty { get; }
    public IEnumerable<Specialty> Specialties { get;}
}
