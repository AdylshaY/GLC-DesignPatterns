using BridgeDP.Payments.Bridge;

namespace BridgeDP.Payments
{
    public abstract class Payment(IPaymentProcess paymentProcess)
    {
        public abstract string GetName();

        public abstract PaymentDetails GetDetail(object details);

        public void Process(decimal amount, string currency, object paymentInfo)
        {
            paymentProcess.ProcessPayment(amount, currency, GetDetail(paymentInfo));
        }
    }
}
