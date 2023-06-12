

using MongoDB.Bson;
using Serilog;
using Sigida.Timetable.App.Services;
using Sigida.Timetable.Data.UoW;
using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.Infrastructures.MongoDb;
using System;
using System.Numerics;


//"mongodb+srv://Timetable:ax9MJ9M7SCfwZZ2@maincluster.x7yabqk.mongodb.net/test"
IMongoContext mongoContext = new MongoContext();
mongoContext.FromConnectionString("mongodb+srv://DenisA1z3K:hFtxmC4Uw2NeEAx@maincluster.x7yabqk.mongodb.net/test");
IUnitOfWork unitofWork = new UnitOfWork(mongoContext);

var timetableService = new TimetableService(unitofWork);

//await DeleteAllCoupleFromTimetable("631453665c34f75061a35061", WeekdayType.Mon);
//await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Mon, new Couple(5, new ObjectId("631585ac283010f4896d4e36"), "302/3", true));

await AddNewDayToTimeTable("631453665c34f75061a35061", WeekdayType.Fri);

await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(2, new ObjectId("63158618283010f4896d4e39"), "43/a", true));
await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(2, new ObjectId("63158618283010f4896d4e39"), "43/a", false));
await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(3, new ObjectId("63158618283010f4896d4e39"), "420/1", true));
await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(3, new ObjectId("63158618283010f4896d4e39"), "420/1", false));

await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(4, new ObjectId("6324c664ab45db9fd5845849"), "402/3", true));
await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(4, new ObjectId("63144dbd610b84edf0041c43"), "413/2", false));

await timetableService.AddLessonToTimetable("ИТ-692", WeekdayType.Fri, new Couple(5, new ObjectId("63144dbd610b84edf0041c43"), "413/2", false));
//await timetableService.AddNewWeekdaToTimetabe("ИТ-692", WeekdayType.Tue);


Console.WriteLine("Все");
Console.ReadLine();

async Task AddNewFaculty(Faculty faculty)
{
    var facultyRep = unitofWork.GetRepository<Faculty>();
    facultyRep.Insert(new Faculty("Компьютерные системы и технологии"));
    await unitofWork.Commit();
}

async Task AddNewSpeciality(string name, string id)
{
    var specRep = unitofWork.GetRepository<Specialty>();
    specRep.Insert(new Specialty(name, new MongoDB.Bson.ObjectId(id)));
    await unitofWork.Commit();
}

async Task AddNewSubject(string name, SubjectType type, string lecture)
{
    var subRep = unitofWork.GetRepository<Subject>();
    subRep.Insert(new Subject(name, type, lecture));
    await unitofWork.Commit();
}

async Task AddNewGroup(string name, string id)
{
    var groupRep = unitofWork.GetRepository<Group>();
    groupRep.Insert(new Group(name, new ObjectId(id)));
    await unitofWork.Commit();
}

async Task AddNewTimetable(string groupId, WeekdayType weekday, int num, string subjectId, string audience, bool onEven)
{
    var timetableRep = unitofWork.GetRepository<Timetable>();
    var timeTable = new Timetable(new ObjectId(groupId), new List<Weekday>()
    {
        new Weekday(weekday, new List<Couple>()
        {
            new Couple(num, new ObjectId(subjectId), audience, onEven)
        })
    });

    timetableRep.Insert(timeTable);

    await unitofWork.Commit();
}

async Task AddNewDayToTimeTable(string timetableId, WeekdayType weekday)
{
    var timetableRep = unitofWork.GetRepository<Timetable>();
    var timetable = await timetableRep.FindById(new ObjectId(timetableId));

    timetable.Weekdays.Add(new Weekday(weekday, new List<Couple>()));

    timetableRep.Update(timetable);

    await unitofWork.Commit();
}

async Task AddCoupleToTimeTable(string timetableId, WeekdayType weekday, int num, string subjectId, string audience, bool onEven)
{
    var timetableRep = unitofWork.GetRepository<Timetable>();
    var timetable = await  timetableRep.FindById(new ObjectId(timetableId));

    var nedWek = timetable.Weekdays.Where(w => w.Day == weekday).FirstOrDefault();

    foreach (var weekdaus in timetable.Weekdays)
    {
        if (weekdaus.Day == weekday)
        {
            weekdaus.Couples.Add(new Couple(num, new ObjectId(subjectId), audience, onEven));
        }
    }

    timetableRep.Update(timetable);

    await unitofWork.Commit();
}

async Task DeleteAllCoupleFromTimetable(string timetableId, WeekdayType weekday)
{
    var timetableRep = unitofWork.GetRepository<Timetable>();
    var timetable = await timetableRep.FindById(new ObjectId(timetableId));

    var nedWek = timetable.Weekdays.Where(w => w.Day == weekday).SingleOrDefault();

    foreach (var weekdaus in timetable.Weekdays)
    {
        if (weekdaus.Day == weekday)
        {
            weekdaus.Couples.Clear();
        }
    }

    timetableRep.Update(timetable);

    await unitofWork.Commit();
}