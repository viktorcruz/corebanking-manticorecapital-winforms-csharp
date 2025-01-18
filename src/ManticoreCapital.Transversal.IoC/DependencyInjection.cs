using ManticoreCapital.Transversal.Common.Response;
using ManticoreCapital.Transversal.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ManticoreCapital.Transversal.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomTransversalIoC(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddSingleton<IDatabaseActionResponse, DatabaseActionResponse>();
            services.AddSingleton(typeof(IDatabaseOperationResult<>), typeof(DatabaseOperationResult<>));
            services.AddSingleton(typeof(IServiceResponse<>), typeof(ServiceResponse<>));

            return services;
        }
    }
}
