using MongoDB.Bson;
using Sigida.Timetable.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.Model;

public class FacultyInfo
{
    private readonly Faculty _faculty;

    public FacultyInfo(Faculty faculty, List<Specialty> specialties)
    {
        _faculty=faculty;
        Specialties=specialties;
    }

    public ObjectId Id => _faculty.Id;
    public string Name => _faculty.Name;

    public List<Specialty> Specialties { get; }
}
