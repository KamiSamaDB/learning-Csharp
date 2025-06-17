using VehicleRentingSystem.Enums;

namespace VehicleRentingSystem.Interfaces
{
    public interface IVehicle
    {
        string VehicleNo { get; set; }
        string Model { get; set; }
        double RentPerDay { get; set; }
        string RenterName { get; set; }
        VehicleType Type { get; }
        void display();
    }
}
