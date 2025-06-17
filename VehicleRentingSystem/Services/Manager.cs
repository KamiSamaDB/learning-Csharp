using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentingSystem.Vehicles;
using VehicleRentingSystem.Enums;

namespace VehicleRentingSystem.Services
{
    internal class Manager
    {
        Car[] cars = new Car[0];
        Bike[] bikes = new Bike[0];
        Truck[] trucks = new Truck[0];

        public void addVehicle(Enums.VehicleType type, string vehicleNo, string model, double rentPerDay, string renterName)
        {
            Logger logger = new Logger();
            switch (type)
            {
                case VehicleType.car:
                    Car car = new Car(vehicleNo, model, rentPerDay, renterName);
                    Array.Resize(ref cars, cars.Length + 1);
                    cars[cars.Length - 1] = car;
                    logger.log($"@{DateTime.Now} : Car added successfully.");
                    break;
                case VehicleType.bike:
                    Bike bike = new Bike(vehicleNo, model, rentPerDay, renterName);
                    Array.Resize(ref bikes, bikes.Length + 1);
                    bikes[bikes.Length - 1] = bike;
                    logger.log($"@{DateTime.Now} : Bike added successfully.");
                    break;
                case VehicleType.truck:
                    Truck truck = new Truck(vehicleNo, model, rentPerDay, renterName);
                    Array.Resize(ref trucks, trucks.Length + 1);
                    trucks[trucks.Length - 1] = truck;
                    logger.log($"@{DateTime.Now} : Truck added successfully.");
                    break;
            }
        }

        public double rentVehicle(Enums.VehicleType type, string vehicleNo, int days)
        {
            switch (type)
            {
                case VehicleType.car:
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].VehicleNo == vehicleNo)
                        {
                            double toPay = cars[i].rent(days);
                            cars[i] = cars[cars.Length - 1];
                            Array.Resize(ref cars, cars.Length - 1);
                            return toPay;
                        }
                    }
                    break;
                case VehicleType.bike:
                    for (int i = 0; i < bikes.Length; i++)
                    {
                        if (bikes[i].VehicleNo == vehicleNo)
                        {
                            double toPay = bikes[i].rent(days);
                            bikes[i] = bikes[bikes.Length - 1];
                            Array.Resize(ref bikes, bikes.Length - 1);
                            return toPay;
                        }
                    }
                    break;
                case VehicleType.truck:
                    for (int i = 0; i < trucks.Length; i++)
                    {
                        if (trucks[i].VehicleNo == vehicleNo)
                        {
                            double toPay = trucks[i].rent(days);
                            trucks[i] = trucks[trucks.Length - 1];
                            Array.Resize(ref trucks, trucks.Length - 1);
                            return toPay;
                        }
                    }
                    break;
            }
            Console.WriteLine("Couldn't find the vehicle, Please Write the correct vehicle number");
            return -1;
        }

        public bool showVehicles(VehicleType type)
        {
            switch (type)
            {
                case VehicleType.car:
                    if (cars.Length == 0)
                    {
                        Console.WriteLine("No cars available");
                        return false;
                    }
                        foreach (Car car in cars)
                    {
                        car.display();
                    }
                    break;
                case VehicleType.truck:
                    if(trucks.Length == 0)
                    {
                        Console.WriteLine("No trucks available");
                        return false;
                    }
                    foreach (Truck truck in trucks)
                    {
                        truck.display();
                    }
                    break;
                case VehicleType.bike:
                    if (bikes.Length == 0)
                    {
                        Console.WriteLine("No bikes available");
                        return false;
                    }
                    foreach (Bike bike in bikes)
                    {
                        bike.display();
                    }
                    break;
            }
            return true;
        }
    }
}
