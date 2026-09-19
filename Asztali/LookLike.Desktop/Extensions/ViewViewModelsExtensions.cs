using LookLike.Desktop.ViewModels;
using LookLike.Desktop.ViewModels.ControlPanel;
using LookLike.Desktop.ViewModels.Login;
using LookLike.Desktop.Views;
using LookLike.Desktop.Views.ControlPanel;
using LookLike.Desktop.Views.Login;
using Microsoft.Extensions.DependencyInjection;
using LookLike.Desktop.Views.StatPanel;
using LookLike.Desktop.Views.NotificationPanel;
using LookLike.Desktop.ViewModels.NotificationPanel;
using LookLike.Desktop.ViewModels.RegistrationPanel;
using LookLike.Desktop.Views.RegistrationPanel;
using LookLike.Desktop.ViewModels.StatPanel;

using LookLike.Desktop.Views.ManagmentPanel;
using LookLike.Desktop.ViewModels.ManagmentPanel;


namespace KretaDesktop.Extensions
{
    public static class ViewViewModelsExtensions
    {
        public static void ConfigureViewViewModels(this IServiceCollection services)
        {
            // MainView
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<MainView>(s => new MainView()
            {
                DataContext = s.GetRequiredService<MainViewModel>()
            });

            // LoginView
            services.AddSingleton<LoginViewModel>();
            services.AddSingleton<LoginView>(s => new LoginView()
            {
                DataContext = s.GetRequiredService<LoginViewModel>()
            });

            // ControlPanel
            services.AddSingleton<ControlPanelViewModel>();
            services.AddSingleton<ControlPanelView>(s => new ControlPanelView()
            {
                DataContext = s.GetRequiredService<ControlPanelViewModel>()
            });


            //Notification
            services.AddSingleton<NotePanelViewModel>();
            services.AddSingleton<NotePanelView>(n => new NotePanelView()//NotePanelView
            {
                DataContext = n.GetRequiredService<NotePanelViewModel>()
            });


            services.AddSingleton<RegistrationPanelViewModel>();
            services.AddSingleton<RegistrationPanelView>(n => new RegistrationPanelView()
            {
                DataContext = n.GetRequiredService<RegistrationPanelViewModel>()
            });




            services.AddSingleton<ManagmentPanelViewModel>();
            services.AddSingleton<AdminManagment>(n => new AdminManagment()
            {
                DataContext = n.GetRequiredService<ManagmentPanelViewModel>()
            });

            services.AddSingleton<StatPanelViewModel>();
            services.AddSingleton<StatPanelView>(n => new StatPanelView()
            {
                DataContext = n.GetRequiredService<StatPanelViewModel>()
            });

        }
    }
}
