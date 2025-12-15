namespace BridgeDP.Payments.Bridge
{
    public interface IPaymentProcess
    {
        void ProcessPayment(decimal amount, string currency, PaymentDetails paymentInfo);
    }
}
