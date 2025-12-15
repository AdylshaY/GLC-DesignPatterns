using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDP.FacadeOrder
{
    public class StockProcess
    {
        public void UpdateStock(string productName, int quantity)
        {
            Console.WriteLine($"[Stock Process]: Product = {productName}, Quantity Updated = {quantity}");
        }
    }
}
