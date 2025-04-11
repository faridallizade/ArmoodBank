using Armood.Domain.RequestAndResponse.Requests;

namespace Armood.Repository.Repositories.Authorize;

public interface IAuthRepository
{
    Task<int> CreateUser(UserRegistrationRequest userRegistrationRequest);
}