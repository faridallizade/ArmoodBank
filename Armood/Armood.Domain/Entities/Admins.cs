namespace Armood.Domain.Entities;

public class Admins
{
    public int AdminId { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Status { get; set; }
    public string SecurityKey { get; set; }
}