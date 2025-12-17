namespace MediatorDP.Modules
{
    public class PaymentModule(IMediator mediator) : BaseModule(mediator, "PaymentModule")
    {
        public void ProcessPayment(string orderDetails)
        {
            Console.WriteLine($"[PaymentModule] Processing payment for order: {orderDetails}");
        }

        public override void Notify(NotifyMessage notifyMessage)
        {
            if (notifyMessage.NotifyType == NotifyType.StockUpdated)
            {
                Console.WriteLine($"[PaymentModule] Sending notification for stock update: {notifyMessage.Message}");
                ProcessPayment(notifyMessage.Message);
            }
        }
    }
}
