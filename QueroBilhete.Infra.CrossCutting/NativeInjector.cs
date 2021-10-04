using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QueroBilhete.Service.Interface;
using QueroBilhete.Service.ViewModels;

namespace QueroBilhete.Infra.CrossCutting
{
    public static class NativeInjector
    {
        public static void RegisterServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);

            #region Services
            services.AddTransient<IUsuarioService<UsuarioViewModel>, UsuarioService>();
            #endregion

            #region Repositories
            services.AddTransient<IBaseRepository, BaseRepository>();
            #endregion
        }
    }
}
