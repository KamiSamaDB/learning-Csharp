using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Vehicles
{
    internal class Bike : Vehicle
    {
        public Bike(string vehicleNo, string model, double rentPerDay, string renterName) : base(vehicleNo, model, rentPerDay, renterName, Enums.VehicleType.bike) { }

        public override double rent(int days)
        {
            return RentPerDay * days;
        }
    }
}
