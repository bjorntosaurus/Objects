using System;
namespace Objects
{
    public class SchoolSystem
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("2026-001", "Kacey Maldo ", 85.0, 90.0, 88.0);
            s1.displayStudentInfo();
            s1.calculateAverage();
            Course c1 = new Course("CS101", "Object-Oriented Programming", 3, 1500.00);
            c1.displayCourseInfo();
            c1.calculateTuition();
            Teacher t1 = new Teacher("T-101", "Abel Bucad", 40, 500.00);
            t1.displayTeacherInfo();
            t1.calculateSalary();
        }   
    }
}
