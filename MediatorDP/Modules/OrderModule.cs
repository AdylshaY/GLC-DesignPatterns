namespace MediatorDP.Modules
{
    public class OrderModule(IMediator mediator) : BaseModule(mediator, "OrderModule")
    {
        public void CreateOrder(string orderDetails)
        {
            Console.WriteLine($"Order Created: {orderDetails}");
            mediator.Send(this, new NotifyMessage(NotifyType.OrderCreated, orderDetails, new Dictionary<string, object> { { "OrderId", 12345 } }, DateTime.Now));
        }

        public override void Notify(NotifyMessage notifyMessage)
        {
        }
    }
}
