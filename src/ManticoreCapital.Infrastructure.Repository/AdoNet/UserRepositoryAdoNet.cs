using ManticoreCapital.Domain.Entities;
using ManticoreCapital.Infrastructure.Interfaces;
using ManticoreCapital.Transversal.Common.Response;
using ManticoreCapital.Transversal.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace ManticoreCapital.Infrastructure.Repositories.AdoNet
{
    public class UserRepositoryAdoNet : IUserRepository
    {
        #region Properties
        private readonly ISqlConnectionFactory _connectionFactory;
        private readonly string CONNECTION_STRING = "Wagner";
        #endregion

        #region Constructor
        public UserRepositoryAdoNet(ISqlConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
        #endregion

        #region Methods
        public async Task<IDatabaseActionResponse> CreateUserAsync(UserEntity user)
        {
            try
            {
                var users = new List<UserEntity>();
                int totalCount = 0;

                using (var connection = _connectionFactory.GetDbConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    var uuid = Guid.NewGuid().ToString();
                    var query = @"
                        INSERT INTO Users(Id, Name, LastName, Email, RFC, PasswordHash, Role, IsActive, CreateAt, LastUpdatedAt)
                                    VALUES(@uuid, @Name, @LastName, @Email, @RFC, @PasswordHash, @Role, @IsActive, @CreatedAt, @LasUpdatedAt)
                        ";
                    using (var command = new SqlCommand(query, connection as SqlConnection))
                    {
                        command.Parameters.AddWithValue("id", uuid);
                        command.Parameters.AddWithValue("Name", user.Name);
                        command.Parameters.AddWithValue("LastName", user.LastName);
                        command.Parameters.AddWithValue("Email", user.Email);
                        command.Parameters.AddWithValue("RFC", user.RFC);
                        command.Parameters.AddWithValue("PasswordHash", user.PasswordHash);
                        command.Parameters.AddWithValue("Role", user.Role);
                        command.Parameters.AddWithValue("IsActive", user.IsActive ? "true" : "false");
                        command.Parameters.AddWithValue("CreatedAt", user.CreatedAt);
                        command.Parameters.AddWithValue("LastUpdatedAt", user.LastUpdatedAt);

                        int affectedRecordId = await command.ExecuteNonQueryAsync();
                        return new DatabaseActionResponse
                        {
                            AffectedRecordId = affectedRecordId,
                            ErrorMessage = "",
                            IsSuccessful = true,
                            Message = "OK",
                            Operation = "CREATE",
                            Timestamp = DateTime.Now,
                        };
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(CONNECTION_STRING, ex);
            }
        }

        public async Task<IDatabaseActionResponse> DeleteUserAsync(string userId)
        {
            try
            {
                var query = "DELETE FROM Banking.Users WHERE ID = @Id";

                using (var connection = _connectionFactory.GetDbConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    using (var command = new SqlCommand(query, connection as SqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", userId);

                        int rowsAffected = await command.ExecuteNonQueryAsync();

                        if (rowsAffected > 0)
                        {
                            return new DatabaseActionResponse
                            {
                                AffectedRecordId = rowsAffected,
                                ErrorMessage = "",
                                IsSuccessful = true,
                                Message = "OK",
                                Operation = "DELETE",
                                Timestamp = DateTime.Now,
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception(CONNECTION_STRING, ex);
            }

            return new DatabaseActionResponse
            {
                AffectedRecordId = 0,
                ErrorMessage = "Error",
                IsSuccessful = false,
                Message = "Error",
                Operation = "DELETE",
                Timestamp = DateTime.Now,
            };
        }

        public Task<IDatabaseOperationResult<UserEntity>> GetUserByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginatedResponse<UserEntity>> GetUserPaginatedAsync(int pageNumber, int pageSize, string? search)
        {
            if (pageNumber <= 0)
            {
                throw new ArgumentException("PageNumber must be greater than zero.", nameof(pageNumber));
            }

            if (pageSize <= 0 || pageSize > 1000)
            {
                throw new ArgumentException("PageSize must be greater than zero and less than or equal to 1000.", nameof(pageSize));
            }

            search ??= string.Empty; // Evitar valores nulos en el filtro

            var users = new List<UserEntity>();
            int totalCount = 0;

            using (var connection = (SqlConnection)_connectionFactory.GetDbConnection(CONNECTION_STRING))
            {
                await connection.OpenAsync();

                var queryPaged = @"
                    SELECT * 
                    FROM Banking.Users
                    WHERE Name LIKE '%' + @Search + '%' 
                       OR LastName LIKE '%' + @Search + '%'
                       OR Email LIKE '%' + @Search + '%' 
                       OR RFC LIKE '%' + @Search + '%'
                    ORDER BY Name
                    OFFSET (@PageNumber - 1) * @PageSize ROWS
                    FETCH NEXT @PageSize ROWS ONLY;
                ";

                using (var command = new SqlCommand(queryPaged, connection))
                {
                    command.Parameters.Add(new SqlParameter("@PageNumber", SqlDbType.Int) { Value = pageNumber });
                    command.Parameters.Add(new SqlParameter("@PageSize", SqlDbType.Int) { Value = pageSize });
                    command.Parameters.Add(new SqlParameter("@Search", SqlDbType.NVarChar, 200) { Value = search });
                    command.CommandTimeout = 90;

                    using (var reader = await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            users.Add(new UserEntity
                            {
                                Id = reader.GetString(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Email = reader.GetString(reader.GetOrdinal("Email")),
                                RFC = reader.GetString(reader.GetOrdinal("RFC")),
                                PasswordHash = reader.GetString(reader.GetOrdinal("PasswordHash")),
                                Role = (RoleType)reader.GetInt32(reader.GetOrdinal("Role")),
                                IsActive = reader.GetBoolean(reader.GetOrdinal("IsActive")),
                                CreatedAt = reader.GetDateTime(reader.GetOrdinal("CreatedAt")),
                                LastUpdatedAt = reader.GetDateTime(reader.GetOrdinal("LastUpdatedAt"))
                            });
                        }
                    }
                }

                var queryTotalCount = @"
                    SELECT COUNT(*) AS TotalCount 
                    FROM Banking.Users
                    WHERE Name LIKE @Search + '%' 
                       OR LastName LIKE @Search + '%'
                       OR Email LIKE @Search + '%' 
                       OR Role LIKE @Search + '%';
                ";

                using (var command = new SqlCommand(queryTotalCount, connection))
                {
                    command.Parameters.Add(new SqlParameter("@Search", SqlDbType.NVarChar, 200) { Value = search });

                    totalCount = (int)await command.ExecuteScalarAsync();
                }
            }

            // Devolver el resultado paginado
            return new PaginatedResponse<UserEntity>(
                results: users,
                totalItemCount: totalCount,
                currentPage: pageNumber,
                itemsPerPage: pageSize
            );
        }



        public async Task<IDatabaseActionResponse> UpdateUserAsync(UserEntity user)
        {
            try
            {
                var query = @"
                    UPDATE Banking.Users 
                        SET Name = @Name,
                            LastName = @LastName,
                            Email = @Email,
                            RFC = @RFC,
                            Role = @Role,
                            IsActive = @IsActive,
                            LastUpdatedAt = @LastUpdatedAt
                    WHERE Id = @Id
                ";

                using (var connection = _connectionFactory.GetDbConnection(CONNECTION_STRING))
                {
                    connection.Open();

                    using (var command = new SqlCommand(query, connection as SqlConnection))
                    {
                        command.Parameters.AddWithValue("@Id", user.Id);
                        command.Parameters.AddWithValue("@Name", user.Name);
                        command.Parameters.AddWithValue("@LastName", user.LastName);
                        command.Parameters.AddWithValue("@Email", user.Email);
                        command.Parameters.AddWithValue("@RFC", user.RFC);
                        command.Parameters.AddWithValue("@Role", user.Role);
                        command.Parameters.AddWithValue("@IsActive", user.IsActive);
                        command.Parameters.AddWithValue("@LastUpdatedAt", (object)DateTime.Now ?? DBNull.Value);

                        await command.ExecuteNonQueryAsync();

                        return new DatabaseActionResponse
                        {
                            IsSuccessful = true,
                            Message = "OK",
                            Operation = "UPDATE",
                            AffectedRecordId = 0,
                            Timestamp = DateTime.UtcNow,
                            ErrorMessage = "NONE"
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
        #endregion
    }
}
