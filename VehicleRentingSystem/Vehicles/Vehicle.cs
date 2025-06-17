using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Vehicles
{
    internal abstract class Vehicle : Interfaces.IVehicle
    {
        public string VehicleNo { get; set; }
        public string Model { get; set; }
        public double RentPerDay { get; set; }
        public string RenterName { get; set; }
        public Enums.VehicleType Type { get; }

        public void display()
        {
            Console.WriteLine($"Vehicle No: {VehicleNo}, Model: {Model}, Rent Per Day: {RentPerDay}, Renter Name: {RenterName}");
        }

        public Vehicle(string vehicleNo, string model, double rentPerDay, string renterName, Enums.VehicleType type)
        {
            VehicleNo = vehicleNo;
            Model = model;
            RentPerDay = rentPerDay;
            RenterName = renterName;
            Type = type;
        }

        public abstract double rent(int days);
    }
}
