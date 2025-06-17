using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Student : IStudent
    {
        private string name;
        private int hindiMarks;
        private int englishMarks;
        private int mathsMarks;
        private int scienceMarks;
        private int socialMarks;
        private int totalMarks;
        private char grade;
        private int studentID;
        private static int studentIDCount = 0;

        public Student(string name, int hindiMarks, int englishMarks, int mathsMarks, int scienceMarks, int socialMarks)
        {
            this.name = name;
            this.hindiMarks = hindiMarks;
            this.englishMarks = englishMarks;
            this.mathsMarks = mathsMarks;
            this.scienceMarks = scienceMarks;
            this.socialMarks = socialMarks;
            studentID = ++Student.studentIDCount;
            CalculateTotalMarks();
            CalculateGrade();
        }

        public void CalculateTotalMarks()
        {
            totalMarks = hindiMarks + englishMarks + mathsMarks + scienceMarks + socialMarks;
        }

        public void CalculateGrade()
        {
            double average = totalMarks / 5.0;
            switch (average)
            {
                case >= 90:
                    grade = 'A';
                    break;
                case >= 75:
                    grade = 'B';
                    break;
                case >= 60:
                    grade = 'C';
                    break;
                case >= 40:
                    grade = 'D';
                    break;
                default:
                    grade = 'F';
                    break;
            }
        }

        public void DisplayStudentDetails()
        {
            Console.WriteLine($"ID: {studentID}, Name: {name}, Total Marks: {totalMarks}, Grade: {grade}");
        }

        public char GetGrade()
        {
            return grade;
        }

        public int GetTotalMarks()
        {
            return totalMarks;
        }
        
        public string GetName()
        {
            return name;
        }

        public int GetStudentID()
        {
            return studentID;
        }
    }
}
