using CandidateNamespace;
using System;
using System.Xml.Linq;
using TripNamespace;
using ValidationNamespace;
using LoggerNamespace;
using LoginNamespace;

namespace MainMenuNamespace
{
    class MainMenu : Trip
    {
        public void menu()
        {
            bool exit = false;
            Login loginObj = new Login();
            loginObj.login();
            while (!exit)
            {
                Logger logger = new Logger();
                Validation validator = new Validation();
                Console.WriteLine("------Main Menu-----");
                Console.WriteLine("1. Add candidate");
                Console.WriteLine("2. Delete candidate");
                Console.WriteLine("3. Print Details");
                Console.WriteLine("4. Cancel Trip");
                Console.WriteLine("5. Exit");
                int choice;
                string choiceInput = "";
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter Choice: ");
                        choiceInput = Console.ReadLine();
                        validator.isChoiceValid(choiceInput);
                        choice = int.Parse(choiceInput);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Error: {e.Message}");
                        logger.log(choiceInput,e.Message);
                    }
                }

                switch (choice)
                {
                    case 1:
                        string name = "";
                        string ageInput = "";
                        int age;
                        string contributionInput = "";
                        double contribution;
                        try
                        {
                            
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter name: ");
                                    name = Console.ReadLine();
                                    validator.isNameValid(name);
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Error: {e.Message}");
                                    logger.log(name,e.Message);
                                }
                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter age: ");
                                    ageInput = Console.ReadLine();
                                    validator.isAgeValid(ageInput);
                                    age = int.Parse(ageInput);
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Error: {e.Message}");
                                    logger.log(ageInput,e.Message);
                                }
                            }
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter contribution: ");
                                    contributionInput = Console.ReadLine();
                                    validator.isContributionValid(contributionInput);
                                    contribution = double.Parse(contributionInput);
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"Error: {e.Message}");
                                    logger.log(contributionInput,e.Message);
                                }
                            }

                            Candidate c = new Candidate(name, age, contribution, true);
                            addCandidate(c);
                            Console.WriteLine("Candidate added successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Error: {e.Message}");
                            logger.log("NULL",e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter name: ");
                        string name2 = Console.ReadLine();
                        deleteCandidate(name2);
                        break;
                    case 3:
                        printCandidate();
                        break;
                    case 4:
                        cancelTrip();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
