using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentingSystem.Services
{
    internal class Logger : Interfaces.ILogger
    {
        private readonly string logFile = @"D:\Visual Studio Projects\VehicleRentingSystem\Logs\logs.txt";

        public Logger()
        {
            if(!File.Exists(logFile))
            {
                File.Create(logFile).Close();
            }
        }

        public void log(string message)
        {
            StreamWriter sw = new StreamWriter(logFile, true);
            sw.WriteLine($"@{DateTime.Now} : {message}");
            sw.Close();
        }
    }
}
