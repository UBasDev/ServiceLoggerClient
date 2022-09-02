using ServiceLoggerClient.Services.Abstracts;
using ServiceLoggerClient.Services.Concretes;

namespace ServiceLoggerClient
{
    public static class ServiceRegistration
    {
        public static void AddAllServices(this IServiceCollection services)
        {
            services.AddHttpClient<IPokemonService, PokemonService>(options =>
            {
                
            });
        }
    }
}
