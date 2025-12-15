using BridgeDP.Payments.Bridge;

namespace BridgeDP.Payments.Implementations
{
    public class PayPalPaymentProcessor : IPaymentProcess
    {
        public void ProcessPayment(decimal amount, string currency, PaymentDetails paymentInfo)
        {
            Console.WriteLine($"[PayPal] Initiating payment: {amount} {currency}");
            Console.WriteLine($"[PayPal] Payment info: {paymentInfo}");
            Console.WriteLine("[PayPal] Transaction completed!");
        }
    }
}
