using Armood.Domain.RequestAndResponse.Requests;
using Armood.Repository.Repositories.Authorize;
using Microsoft.Extensions.Configuration;

namespace Armood.SQLServer.Repositories.AuthRepository;

public class AuthRepository : IAuthRepository
{
    private readonly string _connectionstring; 
    private readonly IConfiguration _configuration;
    //private readonly IUnitOfWork _unitOfWork;



    public AuthRepository(string connectionstring)
    {
        _connectionstring = connectionstring;
    }


    public async Task<bool> CreateUser(UserRegistrationRequest userRegistrationRequest)
    {
        return false;
    }
}

