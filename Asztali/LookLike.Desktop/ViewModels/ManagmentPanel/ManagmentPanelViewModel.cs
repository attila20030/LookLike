using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LookLike.Desktop.ViewModels.Base;

namespace LookLike.Desktop.ViewModels.ManagmentPanel
{
    public partial class ManagmentPanelViewModel : BaseViewModel
    {
        [ObservableProperty]
        private BaseViewModel _currentViewModel;

        private readonly AdminSeeViewModel _adminSeeViewModel;
        private readonly AdminCreateViewModel _adminCreateViewModel;
        private readonly AdminDeleteViewModel _adminDeleteViewModel;
        

        public ManagmentPanelViewModel()
        {
            _adminSeeViewModel = new AdminSeeViewModel();
            _adminCreateViewModel = new AdminCreateViewModel();
            _adminDeleteViewModel = new AdminDeleteViewModel();
        }

        [RelayCommand]
        private void ShowAdminSeeView() => CurrentViewModel = _adminSeeViewModel;

        [RelayCommand]
        private void ShowAdminCreateView() => CurrentViewModel = _adminCreateViewModel;

        [RelayCommand]
        private void ShowAdminDeleteView() => CurrentViewModel = _adminDeleteViewModel;

    }
}
