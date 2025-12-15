using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDP.FacadeOrder
{
    public class ShipmentProcess
    {
        public void ShipOrder(string shipmentType, string address)
        {
            Console.WriteLine($"[Shipment Process]: Shipment Type = {shipmentType}, Address = {address}");
        }
    }
}
