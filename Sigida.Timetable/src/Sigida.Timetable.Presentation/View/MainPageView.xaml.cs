using Sigida.Timetable.Presentation.ViewModel;

namespace Sigida.Timetable.Presentation.View;

public partial class MainPageView : ContentPage
{
	public MainPageView(MainViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}