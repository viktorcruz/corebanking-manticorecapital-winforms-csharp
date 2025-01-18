using ManticoreCapital.Infrastructure.Data;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Infrastructure.Repositories;
using ManticoreCapital.Infrastructure.Repositories.AdoNet;
using ManticoreCapital.Infrastructure.Repositories.Dapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Net;

namespace ManticoreCapital.Infrastructure.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddCustomInfrastructureIoC(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton(configuration);
            services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();

            // adonet
            services.AddSingleton(typeof(RepositoryFactory<>));
            services.AddSingleton<UserRepositoryAdoNet>();
            services.AddSingleton<AccountRepositoryAdoNet>();
            services.AddSingleton<AuditLogRepositoryAdoNet>();
            services.AddSingleton<BranchRepositoryAdoNet>();
            services.AddSingleton<CardRepositoryAdoNet>();
            services.AddSingleton<CustomerRepositoryAdoNet>();
            services.AddSingleton<EmployeeRepositoryAdoNet>();
            services.AddSingleton<LoanRepositoryAdoNet>();
            services.AddSingleton<PaymentRepositoryAdoNet>();
            services.AddSingleton<TransactionRepositoryAdoNet>();
            // dapper
            services.AddSingleton<UserRepositoryDapper>();
            services.AddSingleton<AccountRepositoryDapper>();
            services.AddSingleton<AuditLogRepositoryDapper>();
            services.AddSingleton<BranchRepositoryDapper>();
            services.AddSingleton<CardRepositoryDapper>();
            services.AddSingleton<CustomerRepositoryDapper>();
            services.AddSingleton<EmployeeRepositoryDapper>();
            services.AddSingleton<LoanRepositoryDapper>();
            services.AddSingleton<PaymentRepositoryDapper>();
            services.AddSingleton<TransactionRepositoryDapper>();

            services.AddSingleton<RepositoryFactory<IAccountRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<IAccountRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(AccountRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(AccountRepositoryDapper));

                return factory;
            });

            services.AddSingleton<RepositoryFactory<IAuditLogRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<IAuditLogRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(AuditLogRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(AuditLogRepositoryDapper));

                return factory;
            });

            services.AddSingleton<RepositoryFactory<IBranchRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<IBranchRepository>(serviceProvider);
                
                factory.RegisterRepository(RepositoryType.ADO, typeof(BranchRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(BranchRepositoryDapper));
            
                return factory;
            });

            services.AddSingleton<RepositoryFactory<ICardRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<ICardRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(CardRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(CardRepositoryDapper));

                return factory;
            });

            services.AddSingleton<RepositoryFactory<ICustomerRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<ICustomerRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(CustomerRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(CustomerRepositoryDapper));

                return factory;
            });

            services.AddSingleton<RepositoryFactory<IEmployeeRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<IEmployeeRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(EmployeeRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(EmployeeRepositoryDapper));
                
                return factory;
            });

            services.AddSingleton<RepositoryFactory<ILoanRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<ILoanRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(LoanRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(LoanRepositoryDapper));
               
                return factory;
            });

            services.AddSingleton<RepositoryFactory<IPaymentRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<IPaymentRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(PaymentRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(PaymentRepositoryDapper));
                
                return factory;
            });

            services.AddSingleton<RepositoryFactory<ITransactionRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<ITransactionRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(TransactionRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(TransactionRepositoryDapper));

                return factory;
            });


            services.AddSingleton<RepositoryFactory<IUserRepository>>(serviceProvider =>
            {
                var factory = new RepositoryFactory<IUserRepository>(serviceProvider);

                factory.RegisterRepository(RepositoryType.ADO, typeof(UserRepositoryAdoNet));
                factory.RegisterRepository(RepositoryType.Dapper, typeof(UserRepositoryDapper));

                return factory;
            });

            // adonet
            services.AddSingleton<IUserRepository, UserRepositoryAdoNet>();
            services.AddSingleton<IAccountRepository, AccountRepositoryAdoNet>();
            services.AddSingleton<IAuditLogRepository, AuditLogRepositoryAdoNet>();
            services.AddSingleton<IBranchRepository, BranchRepositoryAdoNet>();
            services.AddSingleton<ICardRepository, CardRepositoryAdoNet>();
            services.AddSingleton<ICustomerRepository, CustomerRepositoryAdoNet>();
            services.AddSingleton<IEmployeeRepository, EmployeeRepositoryAdoNet>();
            services.AddSingleton<ILoanRepository, LoanRepositoryAdoNet>();
            services.AddSingleton<IPaymentRepository, PaymentRepositoryAdoNet>();
            services.AddSingleton<IReportRepository, ReportRepositoryAdoNet>();
            services.AddSingleton<ITransactionRepository, TransactionRepositoryAdoNet>();

            // dapper
            services.AddSingleton<IAccountRepository, AccountRepositoryDapper>();
            services.AddSingleton<IAuditLogRepository, AuditLogRepositoryDapper>();
            services.AddSingleton<IBranchRepository, BranchRepositoryDapper>();
            services.AddSingleton<ICardRepository, CardRepositoryDapper>();
            services.AddSingleton<ICustomerRepository, CustomerRepositoryDapper>();
            services.AddSingleton<IEmployeeRepository, EmployeeRepositoryDapper>();
            services.AddSingleton<ILoanRepository, LoanRepositoryDapper>();
            services.AddSingleton<IPaymentRepository, PaymentRepositoryDapper>();
            services.AddSingleton<IReportRepository, ReportRepositoryDapper>();
            services.AddSingleton<ITransactionRepository, TransactionRepositoryDapper>();
            services.AddSingleton<IUserRepository, UserRepositoryDapper>();

            return services;
        }
    }
}
