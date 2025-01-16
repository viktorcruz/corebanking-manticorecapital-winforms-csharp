using ManticoreCapital.Infrastructure.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ManticoreCapital.Infrastructure.Data
{
    public class SqlConnectionFactory : ISqlConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection GetDbConnection(string connectionString)
        {
            try
            {
                var connection = _configuration.GetConnectionString(connectionString);
                if (connection == null)
                {
                    throw new ArgumentException($"{connectionString} is not a connection");
                }
                return new SqlConnection(connection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
