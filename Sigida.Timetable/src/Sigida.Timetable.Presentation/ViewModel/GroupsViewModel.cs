using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sigida.Timetable.App.Services;
using Sigida.Timetable.Entities.Enums;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.Presentation.Common.Structures;
using Sigida.Timetable.Presentation.Model;
using Sigida.Timetable.Presentation.Services;
using Sigida.Timetable.Presentation.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.ViewModel;

[QueryProperty(nameof(Specialty), nameof(SpecialtyRequest))]
public partial class GroupsViewModel : BaseViewModel
{
    private readonly CourseInformationService _informationService;
    private readonly TimetableInfoService _timetableService;

    public GroupsViewModel(CourseInformationService informationService,
                            TimetableInfoService timetableService)
    {
        _informationService=informationService;
        _timetableService=timetableService;
        GroupTimetable = new();
    }

    [ObservableProperty]
    private SpecialtyRequest _specialty;

    [ObservableProperty]
    private bool _isRefreshing;

    public ObservableCollection<CurrentTimetableGroup> GroupTimetable { get; }

    [RelayCommand]
    private async Task OnPageInvoke()
    {
        Title = Specialty.Name;
        await GetCurrentGroupTimetableListCommand.ExecuteAsync(null);
    }

    [RelayCommand]
    private async Task GetCurrentGroupTimetableList()
    {

        if (GroupTimetable.Count > 0)
            GroupTimetable.Clear();
        IsBusy = true;

        var currentTimetables = await _timetableService.GetCurrentTimetableForSpeciality(Specialty);
        currentTimetables.ToList().ForEach(c => GroupTimetable.Add(c));


        IsBusy = false;
        IsRefreshing = false;

    }
}
