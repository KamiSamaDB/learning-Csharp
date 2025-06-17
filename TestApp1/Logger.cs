using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LoggerNamespace
{
    class Logger
    {
        private readonly string logFile = @"D:\Visual Studio Projects\TestApp1\TestApp1\logs.txt";

        public Logger()
        {
            if (!File.Exists(logFile))
            {
                File.Create(logFile).Close();
            }
        }

        public void log(string input, string message)
        {
            DateTime logTime = DateTime.Now;
            using (StreamWriter sw = new StreamWriter(logFile, true))
            {
                sw.WriteLine($"@{logTime}: input = {input} | error = {message}");
            }
        }

        public void log(string username, string password, DateTime logTime) //Overloading for User logins
        {
            using (StreamWriter sw = new StreamWriter(logFile, true))
            {
                sw.WriteLine($"@{logTime}: User {username} logged in with password: {password}");
            }
        }
    }
}
