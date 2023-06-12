using Sigida.Timetable.Presentation.ViewModel;

namespace Sigida.Timetable.Presentation.View;

public partial class SpecialtiesPageView : ContentPage
{
	public SpecialtiesPageView(SpecialtiesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}