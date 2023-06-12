using Objective.Publisher.App;
using Objective.Publisher.WPF.Common.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.WPF.MVVM.ViewModel
{
    public class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            _communityManager = new();

            WallPublisherView = new(_communityManager);
            CurrentView = WallPublisherView;

            WallPublisherCommand = new RelayCommand(o =>
            {
                CurrentView = WallPublisherView;
            });


        }

        private static CommunityManager _communityManager;
        public static CommunityManager CommunityManager => _communityManager;

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertChanged();
            }
        }

        public WallPublisherViewModel WallPublisherView { get; set; }

        public RelayCommand WallPublisherCommand { get; set; }

    }
}
