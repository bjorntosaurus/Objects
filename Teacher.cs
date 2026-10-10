using System;

namespace Objects

{
    public class Teacher
    {
        string teacherId;
        string teacherName;
        int hoursWorked;
        double ratePerHour;

        public Teacher(string teacherId, string teacherName, int hoursWorked, double ratePerHour)
        {
            this.teacherId = teacherId;
            this.teacherName = teacherName;
            this.hoursWorked = hoursWorked;
            this.ratePerHour = ratePerHour;
        }
        public void calculateSalary()
        {
            double salary = hoursWorked * ratePerHour;
            Console.WriteLine($"Total Salary: {salary:F2}");
        }
        public void displayTeacherInfo()
        {
            Console.WriteLine("TEACHER INFORMATION");
            Console.WriteLine($"Teacher ID: {teacherId}");
            Console.WriteLine($"Teacher Name: {teacherName}");
            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Rate per Hour: {ratePerHour:F2}");
            

        }
    }
}
