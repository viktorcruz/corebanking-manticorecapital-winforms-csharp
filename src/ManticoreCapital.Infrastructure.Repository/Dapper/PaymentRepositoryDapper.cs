using ManticoreCapital.Infrastructure.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreCapital.Infrastructure.Repositories.Dapper
{
    public class PaymentRepositoryDapper : IPaymentRepository
    {
        public readonly ISqlConnectionFactory _connectionFactory;
        public readonly string CONNECTION_STRING = "Wagner";

        public PaymentRepositoryDapper(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        public Task<IDatabaseActionResponse> CreatePaymentAsync(PaymentEntity payment)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> DeletePaymentAsync(string paymentId)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<List<PaymentEntity>>> GetPaymentPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseOperationResult<PaymentEntity>> GetPyamentByIdAsync(PaymentEntity payment)
        {
            throw new NotImplementedException();
        }

        public Task<IDatabaseActionResponse> UpdatePaymentAsync(PaymentEntity payment)
        {
            throw new NotImplementedException();
        }
    }
}
