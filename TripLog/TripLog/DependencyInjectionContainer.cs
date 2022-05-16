using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Reflection;
using TripLog.ViewModels;
using Xamarin.Forms;

namespace TripLog
{
    public static class DependencyInjectionContainer
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            //services.AddSingleton<IMyService, MyService>
            return services;
        }

        public static IServiceCollection ConfigureViewModels(this IServiceCollection services)
        {
            var currentAssembly = Assembly.GetExecutingAssembly();
            foreach (var type in currentAssembly.DefinedTypes
                .Where(e => e.IsSubclassOf(typeof(Page))
                         || e.IsSubclassOf(typeof(BaseViewModel))))
            {
                services.AddTransient(type.AsType());
            }
            return services;
        }
    }
}
