using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Services
{
    internal class MainMenu : Validator
    {
        public void menu()
        {
            bool flag = true;
            Logger logger = new Logger();
            Manager manager = new Manager();

            while (flag)
            {
                Console.WriteLine(" ----- Welcome To Vehicle Renting System ------ ");
                Console.WriteLine("1. Add Vehicle for Renting");
                Console.WriteLine("2. Show Available Vehicles");
                Console.WriteLine("3. Rent Vehicle");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter your choice: ");
                string choiceInput = "";
                int choice = 9;

                try
                {
                    choiceInput = Console.ReadLine();
                    validateChoice(choiceInput);
                    choice = int.Parse(choiceInput);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    logger.log($"Input: {choiceInput} | Error: {e.Message}");
                }

                switch (choice)
                {
                    case 1:
                        string vehicleChoice = "";
                        string vehicleType = "";
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Type of Vehicle: (Car/Bike/Truck)");
                                vehicleChoice = Console.ReadLine();
                                validateVehicle(vehicleChoice);
                                vehicleType = vehicleChoice;
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {vehicleChoice} | Error: {e.Message}");
                            }
                        }
                        string vehicleNoInput = "";
                        string vehicleNo = "";
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Vehicle No: ");
                                vehicleNoInput = Console.ReadLine();
                                validateVehicleNo(vehicleNoInput);
                                vehicleNo = vehicleNoInput;
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {vehicleNoInput} | Error: {e.Message}");
                            }
                        }
                        string vehicleModelInput = "";
                        string vehicleModel = "";
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Model: ");
                                vehicleModelInput = Console.ReadLine();
                                validateVehicleModel(vehicleModelInput);
                                vehicleModel = vehicleModelInput;
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {vehicleModelInput} | Error: {e.Message}");
                            }
                        }
                        string nameInput = "";
                        string name = "";
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Name: ");
                                nameInput = Console.ReadLine();
                                validateName(nameInput);
                                name = nameInput;
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {nameInput} | Error: {e.Message}");
                            }
                        }
                        string rentInput = "";
                        double rent;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Rent: ");
                                rentInput = Console.ReadLine();
                                validateRent(rentInput);
                                rent = double.Parse(rentInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {rentInput} | Error: {e.Message}");
                            }
                        }

                        manager.addVehicle(Enum.Parse<Enums.VehicleType>(vehicleType.ToLower(), true), vehicleNo, vehicleModel, rent, name);

                        break;
                    case 2:
                        Console.WriteLine("Available Vehicles: ");
                        Console.WriteLine("Bikes: ");
                        manager.showVehicles(Enum.Parse<Enums.VehicleType>("bike", true));
                        Console.WriteLine("Cars: ");
                        manager.showVehicles(Enum.Parse<Enums.VehicleType>("car", true));
                        Console.WriteLine("Trucks: ");
                        manager.showVehicles(Enum.Parse<Enums.VehicleType>("truck", true));

                        break;
                    case 3:
                        string rentVehicleChoice = "";
                        string rentVehicleType = "";
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Type of Vehicle: (Car/Bike/Truck)");
                                rentVehicleChoice = Console.ReadLine();
                                validateVehicle(rentVehicleChoice);
                                rentVehicleType = rentVehicleChoice;
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {rentVehicleChoice} | Error: {e.Message}");
                            }
                        }

                        Console.WriteLine("Available Vehicles: ");
                        if(!manager.showVehicles(Enum.Parse<Enums.VehicleType>(rentVehicleType.ToLower(), true))){
                            Console.WriteLine("Returning to Main Menu");
                            continue;
                        }

                        string daysInput = "";
                        int days;

                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter No. of Days: ");
                                daysInput = Console.ReadLine();
                                validateDays(daysInput);
                                days = int.Parse(daysInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {daysInput} | Error: {e.Message}");
                            }
                        }

                        double toPay = -1;
                        while (toPay < 0)
                        {
                            string rentVehicleNoInput = "";
                            string rentVehicleNo = "";
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter Vehicle No: ");
                                    rentVehicleNoInput = Console.ReadLine();
                                    validateVehicleNo(rentVehicleNoInput);
                                    rentVehicleNo = rentVehicleNoInput;
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    logger.log($"Input: {rentVehicleNoInput} | Error: {e.Message}");
                                }
                            }
                            toPay = manager.rentVehicle(Enum.Parse<Enums.VehicleType>(rentVehicleType, true), rentVehicleNo, days);
                        }
                        Console.WriteLine($"Total Rent: {toPay}");
                        string paymentChoice = "";
                        string paymentMethod = "";
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Choose a payment method: (Card/UPI/Cash)");
                                paymentChoice = Console.ReadLine();
                                validatePayment(paymentChoice);
                                paymentMethod = paymentChoice;
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.log($"Input: {paymentChoice} | Error: {e.Message}");
                            }
                        }
                        PaymentProcessor paymentProcessor = new PaymentProcessor();
                        paymentProcessor.processPayment(toPay, Enum.Parse<Enums.PaymentMethod>(paymentMethod, true));
                        Console.WriteLine("Payment Successful");
                        logger.log($"@{DateTime.Now} : Payment Successful, Rent: {toPay}, Payment Method: {paymentMethod}, Cashback given: {0.1*toPay}");
                        paymentProcessor.calculateCashback(toPay);

                        break;
                    case 4:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
