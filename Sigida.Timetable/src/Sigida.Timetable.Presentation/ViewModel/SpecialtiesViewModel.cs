using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic;
using MongoDB.Bson;
using Sigida.Timetable.App.Services;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.Presentation.Common.Structures;
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

[QueryProperty(nameof(Faculty), nameof(FacultyInfo))]
public partial class SpecialtiesViewModel : BaseViewModel
{
    private readonly CourseInformationService _informationService;
    
    public SpecialtiesViewModel(CourseInformationService informationService)
    {
        _informationService=informationService;
        Specialties = new();        
    }

    [ObservableProperty]
    private FacultyInfo _faculty;

    [ObservableProperty]
    private bool _isRefreshing;

    public ObservableCollection<Specialty> Specialties { get; }

    [RelayCommand]
    private async Task GetSpecialtiesInfo()
    {
        if (Specialties.Count > 0)
            Specialties.Clear();
        IsBusy = true;
        var speciatliesInfo = await _informationService.GetDetailsAboutSpecialtiesTheFaculty(Faculty.Id);
        
        foreach (var specialties in speciatliesInfo)
        {
            Specialties.Add(specialties.Key);
        }

        IsRefreshing = false;
        IsBusy = false;
    }

    [RelayCommand]
    private async Task GoToGroupPage(object course)
    {
        if (course is not string && course is null)
            return;

        var specialtyString = course.ToString().Split(':');
        var specialtyRequest = new SpecialtyRequest(new ObjectId(specialtyString[0]), specialtyString[1],int.Parse(specialtyString[2]));



        await Shell.Current.GoToAsync(nameof(GroupsPageView), true, new Dictionary<string, object>
                                                                            {
                                                                                {nameof(Specialty), specialtyRequest}
                                                                            });
    }



}
