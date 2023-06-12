using Sigida.Timetable.UI.View;

namespace Sigida.Timetable.UI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(SpecialtiesPageView), typeof(SpecialtiesPageView));

            Routing.RegisterRoute(nameof(GroupPageView), typeof(GroupPageView));
        }
    }
}