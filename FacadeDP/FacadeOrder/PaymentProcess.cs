using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeDP.FacadeOrder
{
    public class PaymentProcess
    {
        public void MakePayment(string paymentType, double amount)
        {
            Console.WriteLine($"[Payment Process]: Payment Type = {paymentType}, Amount = {amount.ToString("c")}");
        }
    }
}
