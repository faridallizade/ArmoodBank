using Armood.Domain.RequestAndResponse.Requests;
using Armood.Domain.RequestAndResponse.Responses;
using Armood.Domain.Services.Authorize;
using Microsoft.AspNetCore.Mvc;

namespace Armood.Core;

[Route("api/[controller]")]

public class AuthController : Controller
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }
    
    [HttpPost("Register")]
    public async Task<UserResponse> CreateUser([FromBody] UserRegistrationRequest userRegistrationRequest)
    {
        UserResponse userResponse =  new UserResponse();
        // if (ModelState.IsValid)
        // {
        //     userResponse.Success = false;
        //     userResponse.Message = "Registration Failed";
        // }
        // else
        // {
        //     userResponse = await _authService.CreateUser(userRegistrationRequest);
        // }
        // return userResponse;
        //
        
        userResponse = await _authService.CreateUser(userRegistrationRequest);
        return userResponse;

        
    }
}