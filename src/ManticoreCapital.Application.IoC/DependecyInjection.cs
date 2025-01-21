using AutoMapper;
using ManticoreCapital.Application.Mapping;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ManticoreCapital.Application.IoC
{
    public static class DependecyInjection
    {
        public static IServiceCollection AddCustomApplicationIoC(this IServiceCollection services)
        {
            var mapping = new AutoMapper.MapperConfiguration(c =>
            {
                c.AddProfile(new MappingProfile());
            });

            IMapper mapper = mapping.CreateMapper();

            services.AddSingleton(mapper);
            services.AddSingleton<IMediator, Mediator>();

            return services;
        }
    }
}
