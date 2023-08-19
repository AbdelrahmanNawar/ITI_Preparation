using IAP_Demo;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        College college =  College.GetCollege();
        College college2 =  College.GetCollege();

        college.
        College.y

        Course OOP = new Course(1, "OOP");
        Course DB = new Course(2, "Database");
        Course Math = new Course(3, "Math");

        Teacher Abdo = new Teacher("Abdo", true);
        Teacher Roro = new Teacher("Roro", false);

        Student Yara = new Student("Yara", false);
        Student Yass = new Student ("Yass", false);

        Abdo.Courses.Add(OOP);
        Abdo.Courses.Add(DB);
        Roro.Courses.Add(Math);

        Yara.Courses.Add(OOP);
        Yass.Courses.Add(Math);

        college.Courses = new List<Course> { OOP, DB, Math };
        college.Teachers = new List<Teacher> { Abdo, Roro };
        college.Students = new List<Student> { Yara, Yass };

        Console.ReadLine();
    }
}