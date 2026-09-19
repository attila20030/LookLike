using CommunityToolkit.Mvvm.Input;
using LookLike.Desktop.ViewModels.Base;
using LookLike.HttpService;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using LookLike.Shared.Models;
using LookLike.Desktop.Repositories;


namespace LookLike.Desktop.ViewModels.RegistrationPanel
{
    public partial class RegistrationPanelViewModel : BaseViewModel
    {
        private readonly IAdminHttpService _httpService;

        [ObservableProperty]
        private Admin _selectedAdmin = new Admin();

        [ObservableProperty]
        private ObservableCollection<Admin> _admin = new ObservableCollection<Admin>();


        public ObservableCollection<Admin> Admins
        {
            get => _admin;
            set => SetProperty(ref _admin, value);
        }


        public RegistrationPanelViewModel()
        {
            _selectedAdmin = new Admin();
            _httpService = new AdminHttpService();
        }

        public RegistrationPanelViewModel(IAdminHttpService adminHttp)
        {
            _httpService = adminHttp ?? throw new ArgumentNullException(nameof(adminHttp));
            _selectedAdmin = new Admin();
        }

        public override async Task InitializeAsync()
        {
            await UpdateViewAsync();
        }

        [RelayCommand]
        public async Task DoSave(Admin admin)
        {
            if (admin.HasId)
                await _httpService.UpdateAsync(admin);
            else
                await _httpService.InsertAsync(admin);
            await UpdateViewAsync();
            SetUpNewAdmin();
        }

        [RelayCommand]
        public void DoNewAdmin()
        {
            SetUpNewAdmin();
        }

        [RelayCommand]
        public async Task DoDeleteAsync(Admin admin)
        {
            await _httpService.DeleteAsync(admin.Id);
            await UpdateViewAsync();
            SetUpNewAdmin();
        }

        [RelayCommand]
        private async Task UpdateViewAsync()
        {
            List<Admin> admins = await _httpService.GetAllAsync();
            Admins = new ObservableCollection<Admin>(admins);
        }

        [RelayCommand]
        private void SetUpNewAdmin()
        {
            SelectedAdmin = new Admin();
            OnPropertyChanged(nameof(SelectedAdmin));
        }
    }
}





