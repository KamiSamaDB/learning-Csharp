using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerNamespace;
using ValidationNamespace;

namespace LoginNamespace
{
    class Login : Validation
    {
        private string username;
        private string password;
        public void login()
        {
            Logger logger = new Logger();
            string usernameInput = "";
            string passwordInput = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Username: ");
                    usernameInput = Console.ReadLine();
                    isUsernameValid(usernameInput);
                    username = usernameInput;
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    logger.log(usernameInput, e.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Password: ");
                    passwordInput = Console.ReadLine();
                    isPasswordValid(passwordInput);
                    password = passwordInput;
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                    logger.log(passwordInput, e.Message); 
                }
            }
            logger.log(username, password, DateTime.Now);
        }
    }
}
