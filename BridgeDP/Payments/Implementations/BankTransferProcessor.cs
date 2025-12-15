using BridgeDP.Payments.Bridge;

namespace BridgeDP.Payments.Implementations
{
    public class BankTransferProcessor : IPaymentProcess
    {
        public void ProcessPayment(decimal amount, string currency, PaymentDetails paymentInfo)
        {
            Console.WriteLine($"[Bank Transfer] Processing: {amount} {currency}");
            Console.WriteLine($"[Bank Transfer] Details: {paymentInfo}");
            Console.WriteLine("[Bank Transfer] Transfer initiated!");
        }
    }
}
