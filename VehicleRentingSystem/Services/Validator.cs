using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentingSystem.Enums;
using VehicleRentingSystem.Vehicles;

namespace VehicleRentingSystem.Services
{
    internal class Validator
    {
        public void validateChoice(string choice)
        {
            if (!choice.All(char.IsDigit)) throw new Exception("Choice must be a number.");
        }
        
        public void validateVehicle(string vehicle)
        {
            if (!Enum.TryParse<VehicleType>(vehicle, true, out _)) throw new Exception("Please select one out of Car/Bike/Truck");
        }

        public void validateVehicleNo(string vehicleNo)
        {
            if (vehicleNo.Length < 4) throw new Exception("Vehicle No. must be at least 4 characters long.");
        }

        public void validateVehicleModel(string model)
        {
            if (model.Length < 3) throw new Exception("Model must be at least 3 characters long.");
        }

        public void validateRent(string rentPerDay)
        {
            if (!double.TryParse(rentPerDay, out _)) throw new Exception("Rent per day must be a valid number.");
        }
        
        public void validateName(string name)
        {
            if (name.Length < 3) throw new Exception("Name must be at least 3 characters long.");
        }

        public void validateDays(string days)
        {
            if (!days.All(char.IsDigit)) throw new Exception("Days must be a number.");
        }

        public void validatePayment(string payment)
        {
            if(!Enum.TryParse<PaymentMethod>(payment,true,out _)) throw new Exception("Payment method must be Cash/UPI/Card.");
        }
    }
}
