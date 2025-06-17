using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Logger
    {
        private readonly string filePath = "D:\\Visual Studio Projects\\StudentManagement\\logs.txt";

        public Logger()
        {
            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        public void Log(string message)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"@{DateTime.Now}: {message}");
            }
        }
    }
}
