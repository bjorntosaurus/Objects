using System;
namespace Objects
{
    public class Course
    { 
        string courseCode;
        string courseName;
        int units;
        double pricePerUnit;

        public Course(string courseCode, string courseName, int units, double pricePerUnit)
        {
            this.courseCode = courseCode;
            this.courseName = courseName;
            this.units = units;
            this.pricePerUnit = pricePerUnit;
        }
        public void calculateTuition()
        {
            double tuitionFee = units * pricePerUnit;
            Console.WriteLine($"Total Tuition: {tuitionFee:F2}\n");

        }
        public void displayCourseInfo()
        {

            Console.WriteLine("COURSE INFORMATION");
            Console.WriteLine($"Course Code: {courseCode}");
            Console.WriteLine($"Course Name: {courseName}");
            Console.WriteLine($"Units: {units}");
            Console.WriteLine($"Price per Unit: {pricePerUnit:F2}");
            

        }
    }
}
