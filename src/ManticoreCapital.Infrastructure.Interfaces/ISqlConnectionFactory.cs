using System.Data;

namespace ManticoreCapital.Infrastructure.Interfaces
{
    public interface ISqlConnectionFactory
    {
        IDbConnection GetDbConnection(string connectionString);
    }
}
