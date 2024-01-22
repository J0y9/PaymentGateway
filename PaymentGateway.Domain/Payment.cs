namespace PaymentGateway.Domain;

public class Payment : BaseEntity
{
    public decimal Amount { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;
}