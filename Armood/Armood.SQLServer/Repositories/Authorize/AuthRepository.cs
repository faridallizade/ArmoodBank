using Armood.Domain.RequestAndResponse.Requests;
using Armood.Repository.Repositories.Authorize;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace Armood.SQLServer.Repositories.AuthRepository;

public class AuthRepository : IAuthRepository
{
    private readonly string _connectionstring; 
    //private readonly IUnitOfWork _unitOfWork;



    public AuthRepository(string connectionstring, IConfiguration configuration)
    {
        _connectionstring = configuration.GetConnectionString("DefaultConnection");
    }


    public async Task<int> CreateUser(UserRegistrationRequest userRegistrationRequest)
    {
        var connection = _connectionstring;
        await using SqlConnection conn = new SqlConnection(connection);
        await conn.OpenAsync();

        var query =
            "INSERT INTO Users (Name, Surname, Email, PhoneNumber, hashpassword, Birthdate, Gender, CreateDate, Status, SecurityKey, fraud_score) VALUES (@Name, @Surname, @Email, @PhoneNumber, @Password, @BirthDate, @Gender, @CreateDate, @Status, @SecurityKey, @FraudScore)";
        await using SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", userRegistrationRequest.Name);
        cmd.Parameters.AddWithValue("@Surname", userRegistrationRequest.Surname);
        cmd.Parameters.AddWithValue("@Email", userRegistrationRequest.Email);
        cmd.Parameters.AddWithValue("@PhoneNumber", userRegistrationRequest.PhoneNumber);
        cmd.Parameters.AddWithValue("@Password", userRegistrationRequest.Password.GetHashCode());
        cmd.Parameters.AddWithValue("@Birthdate", userRegistrationRequest.Birthdate);
        cmd.Parameters.AddWithValue("@Gender", userRegistrationRequest.Gender);
        cmd.Parameters.AddWithValue("@CreateDate", DateTime.UtcNow);
        cmd.Parameters.AddWithValue("@Status", userRegistrationRequest.Status);
        cmd.Parameters.AddWithValue("@SecurityKey", userRegistrationRequest.SecurityKey.GetHashCode());
        cmd.Parameters.AddWithValue("@FraudScore", 100);
        var rowsAffected = await cmd.ExecuteNonQueryAsync();
        return rowsAffected;
        
    }
    
    
   
}

