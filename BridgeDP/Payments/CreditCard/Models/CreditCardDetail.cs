namespace BridgeDP.Payments.CreditCard.Models
{
    public record CreditCardDetail(string CardNumber, string CardHolderName, string ExpiryDate, string CVV);
}
