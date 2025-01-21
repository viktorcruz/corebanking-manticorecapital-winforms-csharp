-- ============================================
CREATE OR ALTER PROCEDURE [Banking].[Usp_Users_Insert]
        @Id NVARCHAR(100), 
        @Name NVARCHAR(100), 
        @LastName NVARCHAR(100),
        @Email NVARCHAR(255),
        @PasswordHash NVARCHAR(255),
        @Role INT,
        @IsActive BIT,
        @CreatedAt DATETIME,
        @LastUpdatedAt DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @Result AS TABLE
    (
        IsSuccess BIT,
        Message NVARCHAR(100),
        Action NVARCHAR(20),
        RecordId INT,
        TimeStamp DATETIME
    );

    BEGIN TRANSACTION;

    BEGIN TRY
    
        IF EXISTS(SELECT 1 FROM [Banking].[Users] WHERE Id = @Id)
        BEGIN 
            INSERT INTO @Result(IsSuccess, Message, Action, RecordId, TimeStamp)
            VALUES(0, 'Error: User already exists', 'INSERT', NULL, GETDATE());
            
            ROLLBACK TRANSACTION;
            RETURN; 
        END

        INSERT INTO [Banking].[Users]
        (
            Id,
            Name,
            LastName,
            Email,
            PasswordHash,
            Role, 
            IsActive,
            CreatedAt,
            LastUpdatedAt
        )
        VALUES
        (
            @Id,
            @Name,
            @LastName,
            @Email,
            @PasswordHash,
            @Role, 
            @IsActive,
            @CreatedAt,
            @LastUpdatedAt
        );

        
        DECLARE @RecordId INT = (SELECT SCOPE_IDENTITY());

        
        INSERT INTO @Result(IsSuccess, Message, Action, RecordId, TimeStamp)
        VALUES(1, 'Data has been successfully inserted', 'INSERT', @RecordId, GETDATE());

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION;
        END
        
        INSERT INTO @Result(IsSuccess, Message, Action, RecordId, TimeStamp)
        VALUES(0, CONCAT('Error ', ERROR_NUMBER(), ': ', ERROR_MESSAGE(), ' in line ', ERROR_LINE()), 'ERROR', NULL, GETDATE());
        
        THROW; 
    END CATCH;

    SET NOCOUNT OFF;    
    SELECT * FROM @Result;
END;


-- ============================================
CREATE OR ALTER PROCEDURE [Banking].[Usp_Users_GetPage]
    @PageNumber INT,
    @PageSize INT,
    @Search NVARCHAR(100)
AS
BEGIN
	SET NOCOUNT ON;
    SELECT * 
    FROM Banking.Users
    WHERE Name LIKE '%' + @Search + '%' 
       OR LastName LIKE '%' + @Search + '%' 
       OR RFC LIKE '%' + @Search + '%'
    ORDER BY Name
    OFFSET (@PageNumber - 1) * @PageSize ROWS
    FETCH NEXT @PageSize ROWS ONLY;

    SELECT COUNT(*) AS TotalCount 
    FROM Banking.Users
    WHERE Name LIKE '%' + @Search + '%' 
       OR LastName LIKE '%' + @Search + '%' 
       OR RFC LIKE '%' + @Search + '%';
	SET NOCOUNT OFF;
END


EXEC [Banking].[Usp_Users_GetPage] @PageNumber=1,@PageSize=100,@Search=''

SELECT COUNT(*) FROM [Banking].[Users]


