namespace Armood.Domain.Entities;

public class Accounts
{
    public string AccountId { get; set; }
    public string Iban { get; set; }
    public decimal Balance { get; set; }
    public string Currency { get; set; }
    public string AccountType { get; set; }
    public string Status { get; set; }
    public DateTime CrearedAt { get; set; }
}