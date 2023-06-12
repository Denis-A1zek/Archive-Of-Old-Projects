using Sigida.Timetable.UI.ViewModel;

namespace Sigida.Timetable.UI.View;

public partial class FaluctiesPageView : ContentPage
{
	public FaluctiesPageView(FacultiesViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}