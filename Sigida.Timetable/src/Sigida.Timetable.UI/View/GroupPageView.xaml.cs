using Sigida.Timetable.UI.ViewModel;

namespace Sigida.Timetable.UI.View;

public partial class GroupPageView : ContentPage
{
	public GroupPageView(GroupViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}