
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Serilog;
using Sigida.Timetable.App.Services;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.Infrastructures.MongoDb;
using Sigida.Timetable.Presentation.Model;
using Sigida.Timetable.Presentation.View;
using Sigida.Timetable.Presentation.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.Presentation.ViewModel;

public partial class MainViewModel : BaseViewModel
{
    private readonly CourseInformationService _informationService;

    public MainViewModel(CourseInformationService informationService, IMongoContext context)
    {
        Title = "Факультеты";
        _informationService=informationService;
        Faculties = new();
    }

    [ObservableProperty]
    private bool _isRefreshing;

    public ObservableCollection<FacultyInfo> Faculties { get; }

    [RelayCommand]
    private async Task GetFacultyInfo()
    {
        IsBusy = true;
        if (Faculties.Count > 0)
            Faculties.Clear();

        var facultiesInfo = await _informationService.GetDetailsAboutFaculties();

        foreach (var faculty in facultiesInfo)
        {
            var facultyInfo = new FacultyInfo(faculty.Key, 
                                    faculty.Value);
            Faculties.Add(facultyInfo);
        }
        IsBusy = false;
        IsRefreshing = false;
    }

    [RelayCommand]
    private async Task GoToSpecialityPage(FacultyInfo faculty)
    {
        if (faculty is null)
            return;

        await Shell.Current.GoToAsync(nameof(SpecialtiesPageView), true, new Dictionary<string, object>
            {
                {nameof(FacultyInfo), faculty}
            });
    }
}
