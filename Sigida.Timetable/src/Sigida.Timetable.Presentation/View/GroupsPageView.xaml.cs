using Sigida.Timetable.Presentation.ViewModel;

namespace Sigida.Timetable.Presentation.View;

public partial class GroupsPageView : ContentPage
{
	public GroupsPageView(GroupsViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;	
	}
}