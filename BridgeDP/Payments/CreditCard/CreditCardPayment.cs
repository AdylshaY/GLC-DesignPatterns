using BridgeDP.Payments.Bridge;
using BridgeDP.Payments.CreditCard.Models;

namespace BridgeDP.Payments.CreditCard
{
    public class CreditCardPayment(IPaymentProcess paymentProcess) : Payment(paymentProcess)
    {
        public override PaymentDetails GetDetail(object details)
        {
            if (details is not CreditCardDetail)
            {
                throw new ArgumentException("Invalid payment details for Credit Card Payment");
            }

            return new PaymentDetails(((CreditCardDetail)details).CardNumber,
                                      ((CreditCardDetail)details).CardHolderName,
                                      ((CreditCardDetail)details).CVV);
        }

        public override string GetName()
        {
            return "Credit Card Payment";
        }
    }
}
