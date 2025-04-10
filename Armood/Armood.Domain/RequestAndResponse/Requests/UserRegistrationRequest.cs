namespace Armood.Domain.RequestAndResponse.Requests;

public class UserRegistrationRequest
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public DateTime Birthdate { get; set; }
    public string Gender { get; set; }
    public DateTime CreateDate { get; set; }
    public string Status { get; set; }
    public string SecurityKey { get; set; }
    public int FraudScore { get; set; }
}