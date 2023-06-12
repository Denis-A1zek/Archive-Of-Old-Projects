using MongoDB.Bson;
using Serilog;
using Sigida.Timetable.Data.Repository;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Services;

public class FacultyInfoService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Faculty, ObjectId> _facultyRepository;
    private readonly IRepository<Specialty, ObjectId> _specialtyRepository;

    public FacultyInfoService(IUnitOfWork unitOfWork)
    {
        _unitOfWork=unitOfWork;
        _facultyRepository = _unitOfWork.GetRepository<Faculty>();
        _specialtyRepository = _unitOfWork.GetRepository<Specialty>();
    }

    //GetDetailedInfoAboutFaculties - return iEnumarable<FacultyDetails>
    public async Task<IEnumerable<FacultyDetails>> GetDetailedInfoAboutFaculties()
    {
        Log.Information("Получаем информацию о факультетах института");

        List<FacultyDetails> listFacultyDetails = new();
        var faculties = await _facultyRepository.FindAll();

        foreach (var faculty in faculties)
        {
            var specialties = await _specialtyRepository.Find(s => s.FacultyId == faculty.Id);
            Log.Information($"Для факультета {faculty.Name} всего получено {specialties.Count()} специальностей");
            listFacultyDetails.Add(new FacultyDetails(faculty, specialties.ToList()));
        }

        return listFacultyDetails;
    }
}
