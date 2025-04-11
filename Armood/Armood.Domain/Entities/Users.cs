using System.Runtime.InteropServices.JavaScript;

namespace Armood.Domain.Entities;

public class Users
{
    public string UserId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public DateTime Birthdate { get; set; }
    public string Gender { get; set; }
    public DateTime CreateDate { get; set; }
    public int Status { get; set; }
    public string SecurityKey { get; set; }
    public int FraudScore { get; set; }
}