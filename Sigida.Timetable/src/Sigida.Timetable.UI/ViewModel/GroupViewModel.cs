using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.UI.Common;
using Sigida.Timetable.UI.Models;
using Sigida.Timetable.UI.Service;
using Sigida.Timetable.UI.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.ViewModel;

[QueryProperty(nameof(Specialty), nameof(SpecialtyDetails))]
public partial class GroupViewModel : BaseViewModel
{
    
    private readonly TimetableInfoService _timetableInfoService;
    
    [ObservableProperty]
    private SpecialtyDetails _specialty;

    [ObservableProperty]
    private bool _isRefreshing;

    public DayOfWeek DayOfWeek => _timetableInfoService.DayOfWeek;
    public string OnEven => DateTime.Now.IsEven() == true ? "первая неделя" : "вторая неделя";
        

    public GroupViewModel(TimetableInfoService timetableInfoService)
    {
        GroupTimetable = new();
        _timetableInfoService=timetableInfoService;
    }

    public ObservableCollection<CurrentTimetableGroup> GroupTimetable { get; }

    [RelayCommand]
    private async void OnPageInvoke()
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

        var currentTimetables = await _timetableInfoService.GetCurrentTimetableForSpecialty(Specialty);
        if (currentTimetables is null)
            return;

        foreach (var item in currentTimetables)
        {
            GroupTimetable.Add(item);
        }


        IsBusy = false;
        IsRefreshing = false;

    }
}
