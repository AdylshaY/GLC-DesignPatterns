namespace MediatorDP.Modules
{
    public class StockModule(IMediator mediator) : BaseModule(mediator, "StockModule")
    {
        public void DecreaseStock(string product, int quantity)
        {
            Console.WriteLine($"[StockModule] Decreasing stock for {product} by {quantity} units.");
            mediator.Send(this, new NotifyMessage(NotifyType.StockUpdated, $"{quantity} units of {product} decreased.", new Dictionary<string, object> { { "Product", product }, { "Quantity", quantity } }, DateTime.Now));
        }

        public override void Notify(NotifyMessage notifyMessage)
        {
            if (notifyMessage.NotifyType == NotifyType.OrderCreated)
            {
                notifyMessage.ExtraData.TryGetValue("OrderId", out var orderId);

                DecreaseStock("SampleProduct", 1);

                Console.WriteLine($"[StockModule] Processing stock update for new order: {orderId}");
            }
        }
    }
}
