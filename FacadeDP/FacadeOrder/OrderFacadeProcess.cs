using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDP.FacadeOrder
{
    public class OrderFacadeProcess
    {
        private readonly PaymentProcess _paymentProcess;
        private readonly StockProcess _stockProcess;
        private readonly ShipmentProcess _shipmentProcess;

        public OrderFacadeProcess()
        {
            _paymentProcess = new PaymentProcess();
            _stockProcess = new StockProcess();
            _shipmentProcess = new ShipmentProcess();
        }

        public void PlaceOrder(string productName, int quantity, double amount, string paymentType, string shipmentType, string address)
        {
            Console.WriteLine("[Order Facade Process]: Starting order placement...");
            _paymentProcess.MakePayment(paymentType, amount);
            _stockProcess.UpdateStock(productName, quantity);
            _shipmentProcess.ShipOrder(shipmentType, address);
            Console.WriteLine("[Order Facade Process]: Order placement completed.");
        }
    }
}
