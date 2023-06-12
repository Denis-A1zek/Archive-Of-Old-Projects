using Sigida.Timetable.Presentation.View;

namespace Sigida.Timetable.Presentation
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SpecialtiesPageView), typeof(SpecialtiesPageView));
            Routing.RegisterRoute(nameof(GroupsPageView), typeof(GroupsPageView));
        }
    }
}