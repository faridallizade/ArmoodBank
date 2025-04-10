namespace Armood.Domain.Entities;

public class Transactions
{
    public int TransactionId { get; set; }
    public int SenderId { get; set; }
    public int ReceiverId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public DateTime TransactionDate { get; set; }
    public string TransactionType { get; set; }
}