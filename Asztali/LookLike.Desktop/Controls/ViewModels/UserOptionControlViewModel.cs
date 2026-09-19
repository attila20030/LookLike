using CommunityToolkit.Mvvm.ComponentModel;
using LookLike.Desktop.Repositories;
using LookLike.Shared.Models;
using System.Threading;

namespace LookLike.Controls.ViewModels
{


    public partial class UserOptionControlViewModel : ObservableObject
    {
        private AdminRepository _adminRepository = new();

        [ObservableProperty]
        private Admin _currentAdmin = new();

        public UserOptionControlViewModel()
        {
            LoadCurrentAdminData();
        }

        private void LoadCurrentAdminData()
        {
            if (Thread.CurrentPrincipal is not null && Thread.CurrentPrincipal.Identity is not null && Thread.CurrentPrincipal.Identity.Name is not null)
            {
                Admin? admin = _adminRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);

                if (admin is not null)
                {
                    CurrentAdmin.Username = admin.Username;
                }
            }
            CurrentAdmin.Username = "Nincs admin";
        }
    }
}
