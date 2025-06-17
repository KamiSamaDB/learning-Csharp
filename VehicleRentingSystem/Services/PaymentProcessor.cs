using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Services
{
    internal class PaymentProcessor : Interfaces.IPaymentProcessor
    {

        public void calculateCashback(double amount)
        {
            double cashback = amount * 0.1;
            Console.WriteLine($"Cashback of {cashback} is credited to your account");
        }

        public void processPayment(double amount, Enums.PaymentMethod method)
        {
            Console.WriteLine($"Payment of {amount} processed using {method}");
        }
    }
}
