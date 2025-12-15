using BridgeDP.Payments.Bridge;
using BridgeDP.Payments.DigitalWallet.Models;

namespace BridgeDP.Payments.DigitalWallet
{
    public class DigitalWalletPayment(IPaymentProcess paymentProcess) : Payment(paymentProcess)
    {
        public override PaymentDetails GetDetail(object details)
        {
            if (details is not DigitalWalletDetails)
            {
                throw new ArgumentException("Invalid payment details for Digital Wallet Payment");
            }

            // In a real implementation, you would extract the necessary information from the DigitalWalletDetails
            return new PaymentDetails("card number", "card holder name", "cvv");
        }

        public override string GetName()
        {
            return "Digital Wallet Payment";
        }
    }
}
