using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Menu : Validator
    {
        Logger logger = new Logger();
        Manager manager = new Manager();

        public void ShowMenu()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine(" --- Student Management --- ");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Display Students with Grade A");
                Console.WriteLine("4. Exit");
                int choice;
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter your choice: ");
                        string choiceInput = Console.ReadLine();
                        ValidateChoice(choiceInput);
                        choice = int.Parse(choiceInput);
                        break;
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                        logger.Log(e.Message);
                    }
                }

                switch (choice)
                {
                    case 1:
                        string name;
                        int marks1, marks2, marks3, marks4, marks5;
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Student Name");
                                string nameInput = Console.ReadLine();
                                ValidateName(nameInput);
                                name = nameInput;
                                break;
                            }
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.Log(e.Message);
                            }
                        }
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Hindi Marks");
                                string marksInput = Console.ReadLine();
                                ValidateMarks(marksInput);
                                marks1 = int.Parse(marksInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.Log(e.Message);
                            }
                        }
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter English Marks");
                                string marksInput = Console.ReadLine();
                                ValidateMarks(marksInput);
                                marks2 = int.Parse(marksInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.Log(e.Message);
                            }
                        }
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Maths Marks");
                                string marksInput = Console.ReadLine();
                                ValidateMarks(marksInput);
                                marks3 = int.Parse(marksInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.Log(e.Message);
                            }
                        }
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Science Marks");
                                string marksInput = Console.ReadLine();
                                ValidateMarks(marksInput);
                                marks4 = int.Parse(marksInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.Log(e.Message);
                            }
                        }
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Enter Social Marks");
                                string marksInput = Console.ReadLine();
                                ValidateMarks(marksInput);
                                marks5 = int.Parse(marksInput);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                logger.Log(e.Message);
                            }
                        }
                        Student student = new Student(name, marks1, marks2, marks3, marks4, marks5);
                        manager.AddStudent(student);
                        Console.WriteLine("Student Added!");
                        break;
                    case 2:
                        manager.DisplayStudents();
                        break;
                    case 3:
                        manager.DisplayAGrade();
                        break;
                    case 4:
                        Console.WriteLine("Exiting the program...");
                        logger.Log("Exiting the program");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        logger.Log("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
