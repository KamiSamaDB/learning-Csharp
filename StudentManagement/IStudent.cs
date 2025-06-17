using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal interface IStudent
    {
        void CalculateTotalMarks();
        void CalculateGrade();
        void DisplayStudentDetails();
        char GetGrade();
        int GetTotalMarks();
        string GetName();
        int GetStudentID();
    }
}
