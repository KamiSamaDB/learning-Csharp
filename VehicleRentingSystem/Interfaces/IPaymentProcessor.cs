using VehicleRentingSystem.Enums;

namespace VehicleRentingSystem.Interfaces
{
    public interface IPaymentProcessor
    {
        void processPayment(double amount, PaymentMethod method);
        void calculateCashback(double amount);
    }
}
