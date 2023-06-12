using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MongoDB.Bson;
using Sigida.Timetable.Entities.Models;
using Sigida.Timetable.UI.Common;
using Sigida.Timetable.UI.Models;
using Sigida.Timetable.UI.View;
using Sigida.Timetable.UI.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigida.Timetable.UI.ViewModel;

[QueryProperty(nameof(Faculty), nameof(FacultyDetails))]
public partial class SpecialtiesViewModel : BaseViewModel
{
    [ObservableProperty]
    private FacultyDetails _faculty;

    public SpecialtiesViewModel()
    {
    }

    public ObservableCollection<Specialty> Specialties { get; private set; }

    [RelayCommand]
    private async Task OnPageInit()
    {
        Title = Faculty.Faculty.Name;
        Specialties = new(Faculty.Specialties);
    }

    [RelayCommand]
    private async Task GoToGroupPage(object course)
    {
        if (course is not string && course is null)
            return;

        var specialtyString = course.ToString().Split(':');
        var specialtyDetails = new SpecialtyDetails(new ObjectId(specialtyString[0]), specialtyString[1], int.Parse(specialtyString[2]));

        await Shell.Current.GoToAsync(nameof(GroupPageView), true, new Dictionary<string, object>
                                                                    {
                                                                        { nameof(SpecialtyDetails), specialtyDetails }
                                                                    });
    }


}
