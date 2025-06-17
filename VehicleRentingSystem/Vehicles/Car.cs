using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(string vehicleNo, string model, double rentPerDay, string renterName) : base(vehicleNo, model, rentPerDay, renterName, Enums.VehicleType.car) { }

        public override double rent(int days)
        {
            return RentPerDay * days;
        }
    }
}
