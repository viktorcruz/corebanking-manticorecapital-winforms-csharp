using ManticoreCapital.Application.Main.UserUseCsae.Queries.Handler;
using ManticoreCapital.Infrastructure.IoC;
using ManticoreCapital.Presentation.Startup;
using ManticoreCapital.Transversal.IoC;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace ManticoreCapital.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();


            var serviceProvider = new ServiceCollection()
                .AddCustomInfrastructureIoC(configuration)
                .AddCustomTransversalIoC(configuration)
                .AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()))
                .AddMediatR(c => c.RegisterServicesFromAssembly(typeof(GetUserPaginatedQueryHandler).Assembly))
                .BuildServiceProvider();


            var mediator = serviceProvider.GetRequiredService<IMediator>();

            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new StartupFrm(mediator));
        }
    }
}