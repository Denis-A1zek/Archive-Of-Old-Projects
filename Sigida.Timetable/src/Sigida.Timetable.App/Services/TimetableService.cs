using MongoDB.Bson;
using Sigida.Timetable.Data.Repository;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.App.Services;

public class TimetableService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IRepository<Timetable.Entities.Models.Timetable, ObjectId> _timetableRepository;
    private readonly IRepository<Group, ObjectId> _groupRepository;

    public TimetableService(IUnitOfWork unitOfWork)
    {
        _unitOfWork=unitOfWork;
        _timetableRepository = _unitOfWork.GetRepository<Timetable.Entities.Models.Timetable>();
        _groupRepository = _unitOfWork.GetRepository<Group>();
    }

    /// <summary>
    /// Creates a table for the group
    /// </summary>
    /// <param name="groupName">Example "ИТ-692"</param>
    /// <returns></returns>
    public async Task<bool> CreateNewTimetable(string groupName)
    {
        var timetalbeId = await SearchingTheGroupTimetableId(groupName);
        var editedTimetable = await _timetableRepository.FindById(timetalbeId);

        var isContains = editedTimetable is not null;
        if (isContains)
            return false;

        var serachedGroup = await _groupRepository.Find(g => g.Name == groupName);
        var groupId = serachedGroup.FirstOrDefault()?.Id;

        if (groupId is not null)
        {
            _timetableRepository.Insert(new Entities.Models.Timetable(groupId.Value, new List<Weekday>()));
            await _unitOfWork.Commit();
        }

        return false;
    }

    /// <summary>
    /// Add new day to week, if day contains, throw exception
    /// </summary>
    /// <param name="groupName">Example "ИТ-692"</param>
    /// <param name="weekday"></param>
    /// <returns></returns>
    public async Task AddNewWeekdaToTimetabe(string groupName, WeekdayType weekday)
    {
        var timetalbeId = await SearchingTheGroupTimetableId(groupName);
        var editedTimetable = await _timetableRepository.FindById(timetalbeId);

        var notContainWeekday = editedTimetable.Weekdays.Where(w => w.Day == weekday).Count() > 0;

        //TO-DO Ошибка - попытка добавить день недели который уже есть
        if (notContainWeekday)
            return;

        editedTimetable.Weekdays.Add(new Weekday(weekday, new List<Couple>()));
        _timetableRepository.Update(editedTimetable);
        await _unitOfWork.Commit();
    }

    /// <summary>
    /// Add new couple to timetalbe by group name
    /// </summary>
    /// <param name="groupName">Example "ИТ-692"</param>
    /// <param name="weekday"></param>
    /// <param name="couple"></param>
    /// <returns></returns>
    public async Task AddLessonToTimetable(string groupName, WeekdayType weekday, Couple couple)
    {
        var timetableId = await SearchingTheGroupTimetableId(groupName);
        var editedTimetable = await _timetableRepository.FindById(timetableId);

        //TO-DO Ошибка, дня недели нет в базе
        var notContainWeekday = editedTimetable.Weekdays.Where(w => w.Day == weekday).Count() == 0;
        if (notContainWeekday)
            return;

        editedTimetable.Weekdays.ForEach(w =>
        {
            if (w.Day == weekday)
            {
                w.Couples.Add(couple);
            }
        });

        _timetableRepository.Update(editedTimetable);

        await _unitOfWork.Commit();
    }

    public async Task<Timetable.Entities.Models.Timetable> GetTimetable(string groupName)
    {
        var timetableId = await SearchingTheGroupTimetableId(groupName);

        return await _timetableRepository.FindById(timetableId);
    }

    private async Task<ObjectId> SearchingTheGroupTimetableId(string groupName)
    {
        var serachedGroup = await _groupRepository.Find(g => g.Name == groupName);
        var groupId = serachedGroup?.FirstOrDefault()?.Id ?? throw new Exception("Группа не найдена");

        var searchedTimetalbe = await _timetableRepository.Find(t => t.GroupId == groupId);

        return searchedTimetalbe.FirstOrDefault().Id;
    }
}