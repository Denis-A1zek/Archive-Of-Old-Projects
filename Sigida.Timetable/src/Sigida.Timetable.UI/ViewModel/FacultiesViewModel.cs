using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Sigida.Timetable.UI.Models;
using Sigida.Timetable.UI.Services;
using Sigida.Timetable.UI.View;
using Sigida.Timetable.UI.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.ViewModel;

public partial class FacultiesViewModel : BaseViewModel
{
    private readonly FacultyInfoService _facultyInfoService;

    public FacultiesViewModel(FacultyInfoService facultyInfoService)
    {
        Title = "Факультеты";
        _facultyInfoService=facultyInfoService;
        FacultyDetails = new();
        GetInfoAboutFaculiesCommand.Execute(null);
    }

    [ObservableProperty]
    private bool _isRefreshing;

    public ObservableCollection<FacultyDetails> FacultyDetails { get; private set; }

    [RelayCommand]
    public async Task OnPageInit()
    {
        
    }

    [RelayCommand]
    public async Task GetInfoAboutFaculies()
    {
        IsBusy = true;
       
        if (FacultyDetails.Count > 0)
            FacultyDetails.Clear();

        var facultiesDetails = await _facultyInfoService.GetDetailedInfoAboutFaculties();

        foreach (var faculty in facultiesDetails)
        {
            FacultyDetails.Add(faculty);
        }
        IsBusy = false;
        IsRefreshing = false;
        
    }

    //НАСТРОИТЬ РОУТ

    [RelayCommand]
    private async Task GoToSpecialityPage(FacultyDetails faculty)
    {
        if (faculty is null)
            return;

        await Shell.Current.GoToAsync(nameof(SpecialtiesPageView), true, new Dictionary<string, object>
            {
                {nameof(FacultyDetails), faculty}
            });
    }
}
