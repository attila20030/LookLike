using LookLike.HttpService;
using LookLike.Shared.Assemblers;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace LookLike.Desktop.Extensions
{
    public static class DesktopExtension
    {
        public static void AddDesktopServices(this IServiceCollection services)
        {

            services.AddHttpClient("LookLike", configureClient => { configureClient.BaseAddress = new Uri("https://localhost:7120/"); });
            

            services.AddSingleton<IAdminHttpService, AdminHttpService>();
            /*  services.AddSingleton<IBookingHttpService, BookingHttpService>();
              services.AddSingleton<IClientHttpService, ClientHttpService>();
              services.AddSingleton<IUserHttpService, UserHttpService>();*/

            services.AddSingleton<AdminAssembler>();

        }
    }
}
