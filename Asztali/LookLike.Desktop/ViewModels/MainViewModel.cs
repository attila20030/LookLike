using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FontAwesome.Sharp;
using LookLike.Desktop.ViewModels.Base;
using LookLike.Desktop.ViewModels.ControlPanel;
using LookLike.Desktop.ViewModels.StatPanel;
using LookLike.Desktop.ViewModels.NotificationPanel;
using LookLike.Desktop.ViewModels.RegistrationPanel;
using LookLike.Desktop.ViewModels.ManagmentPanel;

namespace LookLike.Desktop.ViewModels
{
    public partial class MainViewModel : BaseViewModel
    {
        private ControlPanelViewModel _controlPanelViewModel;
        private ManagmentPanelViewModel _managmentPanelViewModel;
        private StatPanelViewModel _statPanelViewModel;
        private NotePanelViewModel _notificationPanelViewModel;
        private RegistrationPanelViewModel _registrationPanelViewModel;

        public MainViewModel()
        {
            _controlPanelViewModel = new ControlPanelViewModel();
            _managmentPanelViewModel = new ManagmentPanelViewModel();
            _statPanelViewModel = new StatPanelViewModel();
            _notificationPanelViewModel = new NotePanelViewModel();
            _registrationPanelViewModel = new RegistrationPanelViewModel();
        }

        public MainViewModel(
            ControlPanelViewModel controlPanelViewModel,
            ManagmentPanelViewModel managmentPanelViewModel,
            StatPanelViewModel statPanelViewModel,
            NotePanelViewModel notificationPanelViewModel,
            RegistrationPanelViewModel registrationPanelViewModel
            )
        {
            _controlPanelViewModel = controlPanelViewModel;
            _managmentPanelViewModel = managmentPanelViewModel;
            _statPanelViewModel = statPanelViewModel;
            _notificationPanelViewModel = notificationPanelViewModel;
            _registrationPanelViewModel = registrationPanelViewModel;
            CurrentChildView = _controlPanelViewModel;
            ShowDashbord();
        }

        [ObservableProperty]
        private string _caption = string.Empty;

        [ObservableProperty]
        private IconChar _icon = new IconChar();

        [ObservableProperty]
        private BaseViewModel _currentChildView;

        [RelayCommand]
        public void ShowDashbord()
        {
            Caption = "Főoldal";
            Icon = IconChar.SolarPanel;
            CurrentChildView = _controlPanelViewModel;
        }

        [RelayCommand]
        public void ShowSchoolCitizens()
        {
            Caption = "Szolgáltatások";
            Icon = IconChar.UserGroup;

        }
        [RelayCommand]
        public void ShowManagmentPanel()
        {
            Caption = "Managment";
            Icon = IconChar.Calendar;
            CurrentChildView = _managmentPanelViewModel;
        }
        [RelayCommand]
        public void ShowStatPanel()
        {
            Caption = "Stats";
            Icon = IconChar.ChartLine;
            CurrentChildView = _statPanelViewModel;
        }

        [RelayCommand]
        public void ShowNotificationPanel()
        {
            Caption = "Értesítések";
            Icon = IconChar.Bell;
            CurrentChildView = _notificationPanelViewModel;
        }

        [RelayCommand]
        public void ShowRegistrationPanel()
        {
            Caption = "Regisztráció";
            Icon = IconChar.Bell;
            CurrentChildView = _registrationPanelViewModel;
            _registrationPanelViewModel.InitializeAsync();
        }
    }
}
