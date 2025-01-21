using AutoMapper;
using ManticoreCapital.Application.Main.AccountUseCase.Dtos;
using ManticoreCapital.Application.Main.AutidLogUseCase.Dtos;
using ManticoreCapital.Application.Main.BranchUseCase.Dtos;
using ManticoreCapital.Application.Main.CardUseCase.Dtos;
using ManticoreCapital.Application.Main.CustomerUseCase.Dtos;
using ManticoreCapital.Application.Main.EmployeeUseCase.Dtos;
using ManticoreCapital.Application.Main.LoanUseCase.Dtos;
using ManticoreCapital.Application.Main.PaymentUseCase.Dtos;
using ManticoreCapital.Application.Main.ReportUseCase.Dtos;
using ManticoreCapital.Application.Main.Transaction.Dtos;
using ManticoreCapital.Application.Main.UserUseCsae.Dtos;
using ManticoreCapital.Domain.Entities;

namespace ManticoreCapital.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // commands
            CreateMap<AccountRequestDTO, AccountEntity>().ReverseMap();
            CreateMap<AuditLogRequestDTO, AuditLogEntity>().ReverseMap();
            CreateMap<BranchRequestDTO, BranchEntity>().ReverseMap();
            CreateMap<CardRequestDTO, CardEntity>().ReverseMap();
            CreateMap<CustomerRequestDTO, CustomerEntity>().ReverseMap();
            CreateMap<EmployeeRequestDTO, EmployeeEntity>().ReverseMap();
            CreateMap<LoanRequestDTO, LoanEntity>().ReverseMap();
            CreateMap<PaymentRequestDTO, PaymentEntity>().ReverseMap();
            CreateMap<ReportRequestDTO, ReportEntity>().ReverseMap();
            CreateMap<TransactionRequestDTO, TransactionEntity>().ReverseMap();
            CreateMap<UserRequestDTO, UserEntity>().ReverseMap();

            // queries
            CreateMap<AccountResponseDTO, AccountEntity>().ReverseMap();
            CreateMap<AuditLogResponseDTO, AuditLogEntity>().ReverseMap();
            CreateMap<BranchResponseDTO, BranchEntity>().ReverseMap();
            CreateMap<CardResponseDTO, CardEntity>().ReverseMap();
            CreateMap<CustomerResponseDTO, CustomerEntity>().ReverseMap();
            CreateMap<EmployeeResponseDTO, EmployeeEntity>().ReverseMap();
            CreateMap<LoanResponseDTO, LoanEntity>().ReverseMap();
            CreateMap<PaymentResponseDTO, PaymentEntity>().ReverseMap();
            CreateMap<TransactionResponseDTO, TransactionEntity>().ReverseMap();
            CreateMap<UserResponseDTO, UserEntity>().ReverseMap();
        }
    }
}
