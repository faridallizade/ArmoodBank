using Armood.Domain.RequestAndResponse.Requests;
using Armood.Domain.RequestAndResponse.Responses;

namespace Armood.Domain.Services.Authorize;

public interface IAuthService
{
    Task<UserResponse> CreateUser(UserRegistrationRequest userRegistrationRequest);
}