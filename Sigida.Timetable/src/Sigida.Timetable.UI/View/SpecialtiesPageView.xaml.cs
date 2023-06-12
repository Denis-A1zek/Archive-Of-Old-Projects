using Sigida.Timetable.UI.ViewModel;

namespace Sigida.Timetable.UI.View;

public partial class SpecialtiesPageView : ContentPage
{
	public SpecialtiesPageView(SpecialtiesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}