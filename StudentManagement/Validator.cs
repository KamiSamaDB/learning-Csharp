using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Validator
    {
        public static void ValidateChoice(string input)
        {
            if (!int.TryParse(input, out int result)) throw new Exception("Choice must be a number");
        }
        public static void ValidateMarks(string input)
        {
            if (!int.TryParse(input, out int result)) throw new Exception("Marks must be a number");
            if (int.Parse(input) < 0 || int.Parse(input) > 100) throw new Exception("Marks must be between 0 and 100");
        }

        public static void ValidateName(string input)
        {
            if (string.IsNullOrEmpty(input)) throw new Exception("Name cannot be empty");
        }
    }
}
