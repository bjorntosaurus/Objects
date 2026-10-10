using System;

namespace Objects
{
    public class Student
    {
        string studentId;
        string name;
        double prelimGrade;
        double midtermGrade;
        double finalGrade;

        public Student(string studentId, string name, double prelimGrade, double midtermGrade, double finalGrade)
        {
            this.studentId = studentId;
            this.name = name;
            this.prelimGrade = prelimGrade;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void calculateAverage()
        {
            double average = (prelimGrade + midtermGrade + finalGrade) / 3;
            Console.WriteLine($"Average Grade: {average:F2}");
            if (average > 74)
            {
                Console.WriteLine("Status: PASSED\n");
            }
            else
            {
                Console.WriteLine("Status: FAILED\n");
            }

        }

        public void displayStudentInfo()
        {   
            Console.WriteLine("STUDENT INFORMATION");
            Console.WriteLine($"Student ID: {studentId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Prelim Grade: {prelimGrade:F2}");
            Console.WriteLine($"Midterm Grade: {midtermGrade:F2}");
            Console.WriteLine($"Final Grade: {finalGrade:F2}");
            
        }
    }
}
