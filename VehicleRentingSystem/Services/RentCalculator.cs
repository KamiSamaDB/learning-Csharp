using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Services
{
    internal class RentCalculator : Interfaces.IRentCalculator
    {
        public double calculateRent(double rentPerDay, int days)
        {
            return rentPerDay * days;
        }
    }
}
