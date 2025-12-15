using BridgeDP.GoodExample.Buttons;
using BridgeDP.Payments.CreditCard;
using BridgeDP.Payments.CreditCard.Models;
using BridgeDP.Payments.DigitalWallet;
using BridgeDP.Payments.DigitalWallet.Models;
using BridgeDP.Payments.Implementations;

//var btn = new WindowsButton(new LargeScreen(), new WindowsIpsScreen());

//btn.Draw();
//btn.ChangeScreenSize(new SmallScreen());
//btn.Draw();


var creditCardPayment = new CreditCardPayment(new PayPalPaymentProcessor());
var creditCardDetails = new CreditCardDetail("1234-5678-9012-3456", "John Doe", "12/26", "123");
creditCardPayment.Process(100.50m, "USD", creditCardDetails);

var walletWithBank = new DigitalWalletPayment(new BankTransferProcessor());
var walletDetails = new DigitalWalletDetails("wallet-12345", "user@example.com");
walletWithBank.Process(500.00m, "TRY", walletDetails);