using mf.domain.Handlers;
using mf.domain.Repositories;
using mf.infra.Data;
using Microsoft.Extensions.DependencyInjection;

namespace mf.ioc
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection service)
        {
            service.AddScoped<IMinecraftRepository, MinecraftRepository>();

            service.AddTransient<MinecraftHandler>();

        }
    }
}
