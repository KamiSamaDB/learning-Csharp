using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class Manager
    {
        private List<Student> students;
        private static Logger logger = new Logger();

        public Manager()
        {
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
            logger.Log($"Student Added: ID-{student.GetStudentID()} Name-{student.GetName()} Total Marks-{student.GetTotalMarks()} Grade-{student.GetGrade()}");
        }

        public void DisplayStudents()
        {
            bool found = false;
            Console.WriteLine("Student Details:");
            foreach (Student student in students)
            {
                found = true;
                student.DisplayStudentDetails();
            }
            if (!found)
            {
                Console.WriteLine("No students found.");
            }
        }

        public void DisplayAGrade()
        {
            Console.WriteLine("Students with Grade A:");
            bool found = false;
            foreach (Student student in students)
            {
                if (student.GetGrade() == 'A')
                {
                    found = true;
                    student.DisplayStudentDetails();
                }
            }
            if (!found)
            {
                Console.WriteLine("No students with Grade A found.");
            }
        }
    }
}
