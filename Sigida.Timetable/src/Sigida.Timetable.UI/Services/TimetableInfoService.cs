using MongoDB.Bson;
using Serilog;
using Sigida.Timetable.Data.Repository;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.UI.Common.Interfaces;
using Sigida.Timetable.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.Service;

public class TimetableInfoService
{
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

    #region old
    //public async Task<IEnumerable<CurrentTimetableGroup>> GetCurrentTimetableForSpeciality(ISpecialtyInfo specialtyRequest)
    //{
    //    Log.Information($"Получаем расписание на {DayOfWeek} для специальности {specialtyRequest.Name}");
    //    var detailsInfo = await GetInfoAboutCurrentTimetableSpecialties(specialtyRequest);
    //    var listCurrentTimetable = new List<CurrentTimetableGroup>();
    //    //TO-DO ЕСЛИ НЕТ ПАР НЕ ОБХОДИМ
    //    foreach (var group in detailsInfo)
    //    {
    //        var couples = group.Value.Couples;
    //        var listLessonsDetails = new List<LessonDetails>();
    //        foreach (var couple in couples)
    //        {
    //            var subjects = await _subjectRepository.Find(s => s.Id == couple.SubjectId);
    //            var subjectInfo = subjects.FirstOrDefault() ?? throw new Exception("Ошибка, не удалось найти предмет для пары");

    //            listLessonsDetails.Add(new LessonDetails(couple.Num, subjectInfo.Name, couple.Audience, couple.OnEven));
    //            listLessonsDetails = listLessonsDetails.OrderBy(l => l.Number).ToList();
    //        }

    //        var currentTimetable = new CurrentTimetableGroup((DayOfWeek)group.Value.Day, group.Key.Name, listLessonsDetails);
    //        Log.Information($"Расписание для группы {group.Key.Name} в количестве {listLessonsDetails.Count} пар");
    //        listCurrentTimetable.Add(currentTimetable);
    //    }

    //    return listCurrentTimetable;
    //}

    //private async Task<Dictionary<Group, Weekday>> GetInfoAboutCurrentTimetableSpecialties(ISpecialtyInfo specialtyInfo)
    //{
    //    Log.Information($"Получаем расписание на {DayOfWeek}");
    //    var groupsTimetable = await GetDetailsTimetableForGroups(specialtyInfo.Id);
    //    var currentCourse = groupsTimetable.Where(g => g.Key.Course == specialtyInfo.Course);

    //    //TO-DO Вот тут получаем подробную инфу о расписаинии, сделать кеширование

    //    var groupWeekdayValuePair = new Dictionary<Group, Weekday>();
    //    foreach (var groupTimetable in currentCourse)
    //    {
    //        var currentWeekday = groupTimetable.Value.Weekdays.Where(s => s.Day == (WeekdayType)DayOfWeek).FirstOrDefault();

    //        Log.Information($"Для группы {groupTimetable.Key.Name} получено расписание со статусом {currentWeekday is not null}");
    //        groupWeekdayValuePair.Add(groupTimetable.Key, currentWeekday);
    //    }

    //    return groupWeekdayValuePair;
    //}

    //private async Task<Dictionary<Group, Timetable.Entities.Models.Timetable>> GetDetailsTimetableForGroups(ObjectId specialtyId)
    //{
    //    Log.Information($"Получаем детальное расписание для группы");
    //    var groupsOfSpecialty = await _groupRepository.Find(g => g.SpecialityId == specialtyId);
    //    var listTimetablesOfGroup = new Dictionary<Group, Timetable.Entities.Models.Timetable>();

    //    foreach (var group in groupsOfSpecialty)
    //    {
    //        var groupTimetableQuery = await _timetableRepository.Find(t => t.GroupId == group.Id);
    //        var groupTimetable = groupTimetableQuery.FirstOrDefault() ?? throw new Exception("Расписание не было найдено");
    //        Log.Information($"Для группы {group.Name} было получено расписание со статусом {groupTimetable is not null}");
    //        listTimetablesOfGroup.Add(group, groupTimetable);
    //    }

    //    return listTimetablesOfGroup;
    //}
    #endregion
    public async Task<IEnumerable<CurrentTimetableGroup>> GetCurrentTimetableForSpecialty(ISpecialtyInfo specialtyInfo)
    {
        Log.Information($"GetCurrentTimetableForSpecialty() : получаем расписание на день {DayOfWeek} для специальности {specialtyInfo.Name}");
        List<CurrentTimetableGroup> currentTimetableGroups = new List<CurrentTimetableGroup>();
        var groupsOfSpecialty = await _groupRepository.Find(g => g.SpecialityId == specialtyInfo.Id);
        var currentCourse = groupsOfSpecialty.Where(g => g.Course == specialtyInfo.Course);
        if (currentCourse is null)
            return new List<CurrentTimetableGroup>();

        foreach (var group in currentCourse)
        {
            var timetable = await GetTimetableForDayOfWeek(group.Id, DayOfWeek);
            currentTimetableGroups.Add(timetable);
        }

        return currentTimetableGroups;
    }

    public async Task<CurrentTimetableGroup> GetTimetableForDayOfWeek(ObjectId groupId, DayOfWeek dayOfWeek)
    {
        Log.Information($"GetTimetableFordayOfWeek() : получаем расписаине для группы {groupId}");

        var lessonsDetails = new List<LessonDetails>();

        var group = await GetInfoAboutGroup(groupId);
        var groupTimetable = await GetTimetableForGroup(groupId);
        var neededWeekday = GetDayOfWeek(groupTimetable, dayOfWeek);

        foreach (var couple in neededWeekday.Couples)
        {
            if(couple.OnEven == DateTime.Now.IsEven())
            {
                var subject = await GetInfoAboutSubject(couple.SubjectId);
                lessonsDetails.Add(new LessonDetails(couple.Num, subject.Name, couple.Audience, couple.OnEven));
                lessonsDetails = lessonsDetails.OrderBy(l => l.Number).ToList();
            }
        }

        return new CurrentTimetableGroup(DayOfWeek, group.Name, lessonsDetails);
    }

    private async Task<Group> GetInfoAboutGroup(ObjectId groupId)
    {
        Log.Information($"GetInfoAboutGroup(): Получаем информацию о группе {groupId}");
        var groups = await _groupRepository.Find(g => g.Id == groupId);
        var group = groups.FirstOrDefault() ?? throw new Exception("Группы не существует");
        return group;
    }

    private Weekday GetDayOfWeek(Timetable.Entities.Models.Timetable timetable, DayOfWeek dayOfWeek)
    {
        Log.Information($"GetDayOfWeek(): Получаем расписание на день {dayOfWeek} для группы {timetable.GroupId}");
        var weekdays = timetable.Weekdays.Where(w => (DayOfWeek)w.Day == DayOfWeek);
        var weekday = weekdays.FirstOrDefault();
        if (weekday is null)
            return new Weekday((WeekdayType)dayOfWeek, new List<Couple>());
        return weekday;
    }

    private async Task<Timetable.Entities.Models.Timetable> GetTimetableForGroup(ObjectId groupId)
    {
        Log.Information($"GetTimetableForGroup(): Получаем расписание для группы {groupId}");
        var timetables = await _timetableRepository.Find(t => t.GroupId == groupId);
        var timetable = timetables.FirstOrDefault() ?? throw new Exception("Расписание для группы не существует");
        return timetable;
    }

    private async Task<Subject> GetInfoAboutSubject(ObjectId subjectId)
    {
        Log.Information($"GetInfoAboutSubject(): Получаем инфморацию о предмете {subjectId}");
        var subjects = await _subjectRepository.Find(s => s.Id == subjectId);
        var subjectInfo = subjects.FirstOrDefault() ?? throw new Exception("Ошибка, не удалось найти предмет для пары");
        return subjectInfo;
    }

    //Получить расписание на день недели 
    //Получить все расписание для специальности 
    //Получить полное расписание для группы
}