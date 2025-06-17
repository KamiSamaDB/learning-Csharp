using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Vehicles
{
    internal class Truck : Vehicle
    {
        public Truck(string vehicleNo, string model, double rentPerDay, string renterName) : base(vehicleNo, model, rentPerDay, renterName, Enums.VehicleType.truck) { }

        public override double rent(int days)
        {
            return RentPerDay * days;
        }
    }
}
