using Armood.Domain.RequestAndResponse.Requests;
using Armood.Domain.RequestAndResponse.Responses;
using Armood.Domain.Services.Authorize;
using Armood.Domain.Services.User;
using Armood.Repository.Repositories.Authorize;

namespace Armood.Application.Services.Authorize;

public class AuthService :IAuthService
{
    private readonly IAuthRepository _authRepository;

    public AuthService(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }


    public async Task<UserResponse> CreateUser(UserRegistrationRequest userRegistrationRequest)
    {
        UserResponse userResponse = new UserResponse();
        var result = await _authRepository.CreateUser(userRegistrationRequest);
        if (result == 0)
        {
            userResponse.Success = false;
            userResponse.Message = "User created unsuccessfully";
            return new UserResponse();
        }
            userResponse.Success = true;
            userResponse.Message = "User created successfully";
        return userResponse;
    }
}