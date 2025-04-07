using NewsApp.MVVM.View;
using NewsApp.MVVM.ViewModel;
using NewsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Bootstrapper
{
    public static class ServiceConfig
    {
        public static void AddService(IServiceCollection services) 
        {
            services.AddSingleton<NewsService>();
            services.AddSingleton<NewsViewModel>();
            services.AddSingleton<NewsPage>();

            services.AddSingleton<NewsDetailViewModel>();
            services.AddSingleton<NewsDetailPage>();


        }
    }
}
