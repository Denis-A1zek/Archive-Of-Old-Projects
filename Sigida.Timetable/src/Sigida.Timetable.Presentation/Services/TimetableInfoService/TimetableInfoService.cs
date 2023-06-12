using MongoDB.Bson;
using Sigida.Timetable.Data.Repository;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.Presentation.Common.Structures;
using Sigida.Timetable.Presentation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DayOfWeek = System.DayOfWeek;

namespace Sigida.Timetable.Presentation.Services;

public class TimetableInfoService
{
    private DayOfWeek _dayOfWeek;

    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Entities.Models.Timetable, ObjectId> _timetableRepository;
    private readonly IRepository<Group, ObjectId> _groupRepository;
    private readonly IRepository<Subject, ObjectId> _subjectRepository;

    public TimetableInfoService(IUnitOfWork unitOfWork)
    {
        _unitOfWork=unitOfWork;
        _timetableRepository = unitOfWork.GetRepository<Timetable.Entities.Models.Timetable>();
        _groupRepository = _unitOfWork.GetRepository<Group>();
        _subjectRepository = _unitOfWork.GetRepository<Subject>();
    }

    public DayOfWeek DayOfWeek
    {
        get
        {
            if (!(DateTime.Now.DayOfWeek == System.DayOfWeek.Sunday || DateTime.Now.DayOfWeek == System.DayOfWeek.Saturday))
            {
                return DateTime.Now.DayOfWeek;
            }
            return DayOfWeek.Monday;
        }
    }

    public async Task<IEnumerable<CurrentTimetableGroup>> GetCurrentTimetableForSpeciality(SpecialtyRequest specialtyRequest)
    {
        var detailsInfo = await GetInfoAboutCurrentTimetableSpecialties(specialtyRequest);
        var listCurrentTimetable = new List<CurrentTimetableGroup>();

        foreach (var group in detailsInfo)
        {
            var couples = group.Value.Couples;
            var listLessonsDetails = new List<LessonDetails>();
            foreach (var couple in couples)
            {
                var subjects = await _subjectRepository.Find(s => s.Id == couple.SubjectId);
                var subjectInfo = subjects.FirstOrDefault() ?? throw new Exception("Ошибка, не удалось найти предмет для пары");

                listLessonsDetails.Add(new LessonDetails(couple.Num, subjectInfo.Name, couple.Audience, couple.OnEven));
                listLessonsDetails = listLessonsDetails.OrderBy(l => l.Number).ToList();
            }

            var currentTimetable = new CurrentTimetableGroup((DayOfWeek)group.Value.Day, group.Key.Name, listLessonsDetails);
            listCurrentTimetable.Add(currentTimetable);
        }

        return listCurrentTimetable;
    }

    private async Task<Dictionary<Group, Weekday>> GetInfoAboutCurrentTimetableSpecialties(SpecialtyRequest specialtyInfo)
    {
        var groupsTimetable = await GetDetailsTimetableForGroups(specialtyInfo.Id);
        var currentCourse = groupsTimetable.Where(g => g.Key.Course == specialtyInfo.Course);

        //TO-DO Вот тут получаем подробную инфу о расписаинии, сделать кеширование

        var groupWeekdayValuePair = new Dictionary<Group, Weekday>();
        foreach (var groupTimetable in currentCourse)
        {
            var currentWeekday = groupTimetable.Value.Weekdays.Where(s => s.Day == (WeekdayType)DayOfWeek).FirstOrDefault();

            groupWeekdayValuePair.Add(groupTimetable.Key, currentWeekday);
        }

        return groupWeekdayValuePair;
    }

    private async Task<Dictionary<Group, Timetable.Entities.Models.Timetable>> GetDetailsTimetableForGroups(ObjectId specialtyId)
    {
        var groupsOfSpecialty = await _groupRepository.Find(g => g.SpecialityId == specialtyId);
        var listTimetablesOfGroup = new Dictionary<Group, Timetable.Entities.Models.Timetable>();

        foreach (var group in groupsOfSpecialty)
        {
            var groupTimetableQuery = await _timetableRepository.Find(t => t.GroupId == group.Id);
            var groupTimetable = groupTimetableQuery.FirstOrDefault() ?? throw new Exception("Расписание не было найдено");
            listTimetablesOfGroup.Add(group, groupTimetable);
        }

        return listTimetablesOfGroup;
    }

    //public async Task<IEnumarable<MyClass>> GetTimetableForGroup()
    //{

    //}

    //TO-DO получить текущее расписание для всех групп выбранной специальности
    //TO-DO получить полное расписание выбранной группы

}
