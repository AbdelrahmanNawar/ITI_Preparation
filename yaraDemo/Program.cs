//internal class Program
//{

//    private static void Main(string[] args)
//    {
//       Person yara = new Person("yara", "nawar", 12, "34567654", false);
//        Person yasso = new Person();
//        yara.SetFullName();
//        yara.Print();
//        Console.WriteLine();
//    }

//}

//public class Person
//{
//    public Person() // constructor
//    {

//    }
//    public Person(string firstName, string lastName, int age, string id, bool isMarried)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//        Id = id;
//        IsMarried = isMarried;
//    }

//    public string FirstName;
//    public string LastName;
//    private string FullName;
//    public int Age;
//    private string Id;
//    public bool IsMarried;

//    public void SetFullName()
//    {
//        FullName = FirstName + " " + LastName;
//    }

//    public void Print()
//    {
//        Console.WriteLine($"Id: {Id}, Name: {FullName}");
//    }
//}

using System.Runtime.CompilerServices;

//internal class Program
//{

//    private static void Main(string[] args)
//    {
//        Car BMW = new Car("BMW", 1600, 15650.93);
//        Car Merc = new Car();
//        Merc.CarName = "Mecr";
//        Merc.CarCC = 2200;
//        Merc.SetCarCost(3524277);
//        Console.WriteLine(Merc.GetPrintCost());
//    }

//}
//public class Car
//{
//    public Car()
//    {

//    }
//    public Car(string CarName, int CarCC, double CarCost)
//    {
//        this.CarName = CarName;
//        this.CarCC = CarCC;
//        this.CarCost = CarCost;
//    }

//    public string CarName;
//    public int CarCC;
//    private double CarCost;

//    public void SetCarCost(double CarCost)
//    {
//        this.CarCost = CarCost;
//    }
//    public double GetPrintCost()
//    {
//        return CarCost;
//    }
//}

internal class Program
{

    private static void Main(string[] args)
    {
        MathBase.Sum()

        //Bike b1 = new Bike();
        //b1.Name = "BMW";
        //b1.SetPrice(8451209856);

        //Bike b2 = new Bike();
        //b2.Name = b1.Name;
        //double x = b1.GetPrice();
        //b2.SetPrice(x);

        // after birthday year with 6 years
        // and you birth date before 09 / 01
        // then birthday year with 7 years
        // 1994 10 01 => 2001 09 01

        //Yara Nawar, Id: 5, birthday: 1996_09_28, school year: 68451323

        //Person yasso = new Person();
        //yasso.FirstName = "Yasso";
        //yasso.LastName = "Reda";
        //yasso.BirthDate = 1996_09_28;
        //Person yasso = new Person("Yasso", "Reda", 1996_09_28);
        //yasso.GetSchoolYear();
        //yasso.SetId(500);

        //Person yara = new Person();
        //yara.FirstName = "yara";
        //yara.LastName = "NAWAR";
        //yara.BirthDate = 1997_09_13;
        //yara.GetSchoolYear();
        //yara.SetId(303);

        //yara.PrintF();
        //yasso.PrintF();

        #region basic

        //string yaraName = "yara";
        //int yaraBD = 1997_09_13;

        //string abdouName = "Abdou";
        //int abdouBD = 1995_08_26;

        //var yaraSchoolYear = GetSchoolYear(yaraBD);
        //var abdouSchoolYear = GetSchoolYear(abdouBD);

        //Person yara = new Person();
        //yara.Name = "yara";
        //yara.BirthDay = 1997_09_13;

        //yaraSchoolYear = yara.GetSchoolYear();

        //Console.WriteLine($"yara's School Year is: {yaraSchoolYear}");
        //Console.WriteLine($"{(yaraBD / 10_000) * 10_000}");

        /// birthday remainder 4 is 0
        /// and birthday % 100 is not 0
        /// or birthday % 400 is 0
        //int birthday = 2100;
        //bool isOlder = 2023 - yaraBD > 2023 - 1998;
        //if ((birthday % 4 == 0 && birthday % 100 != 0) || birthday % 400 == 0)
        //    Console.WriteLine("kwefbkjfbkjwefbkf");
        #endregion

        //BasicStruct b1 = new BasicStruct();
        //b1.X = 1;
        //b1.Y = 2;
        //b1.Z = 3;

        //BasicStruct b2 = new BasicStruct(1,2,3);
        //b2.X = 4;
        //b2.Y = 5;
        //b2.Z = 6;

        //BasicClass b3 = new BasicClass();
        //b3.X = 1;
        //b3.Y = 2;
        //b3.Z = 3;

        //BasicClass b4 = b3;
        //b4.X = 4;
        //b4.Y = 5;
        //b4.Z = 6;
        //Console.WriteLine($"b1.x: {b1.x}");
        //Console.WriteLine($"b1.y: {b1.y}");
        //Console.WriteLine($"b1.z: {b1.z}");
        //Console.WriteLine("========================");
        //Console.WriteLine($"b2.x: {b2.x}");
        //Console.WriteLine($"b2.y: {b2.y}");
        //Console.WriteLine($"b2.z: {b2.z}");
        //Console.WriteLine("========================");
        //Console.WriteLine($"b3.x: {b3.X}");
        //Console.WriteLine($"b3.y: {b3.Y}");
        //Console.WriteLine($"b3.z: {b3.Z}");
        //Console.WriteLine("========================");
        //Console.WriteLine($"b4.x: {b4.X}");
        //Console.WriteLine($"b4.y: {b4.Y}");
        //Console.WriteLine($"b4.z: {b4.Z}");
        //Console.WriteLine("========================");
    }
}

public struct BasicStruct
{
    public BasicStruct(int x, int y)
    {
        X = x;
        Y = y;
        Z = 0;
    }
    public int X;
    public int Y;
    public int Z;
}

public class BasicClass
{
    public BasicClass(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
    public int X;
    public int Y;
    public int Z;
}

public class Person
{
    public Person(string firstName, string lastName, int birthdate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthdate;
    }
    private int Id; // field
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int BirthDate { get; set; }
    public int SchoolYear { get; set; } // property

    public int GetId()
    {
        return Id;
    }

    public void SetId(int id)
    {
        if (id < 100)
            return;

        if (id > 1000)
            return;

        Id = id;
    }

    public void GetSchoolYear()
    {
        int schoolDate = 09_01;

        int monthDay = BirthDate % 10_000;
        if (monthDay < schoolDate)
        {
            SchoolYear = (BirthDate / 10_000 + 6) * 10_000 + schoolDate;
        }
        else
        {
            SchoolYear = (BirthDate / 10_000 + 7) * 10_000 + schoolDate;
        }
    }

    public void PrintF()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}, ID: {Id}, Birthday: {BirthDate}, school year: {SchoolYear}");
    }
}

//public class Person
//{
//    public string Name { get; set; }
//    public int BirthDay { get; set; }
//    public Person()
//    {

//    }

//    public int GetSchoolYear()
//    {
//        int monthAndDay = BirthDay % 10_000;
//        bool khadsf = monthAndDay > 0901;
//        if (khadsf)
//            return (BirthDay / 10_000 + 7) * 10_000 + 09 * 100 + 1;
//        else
//        {
//            int schoolDate = (BirthDay / 10_000 + 6) * 10_000 + 09 * 100 + 1;
//            return schoolDate;
//        }
//    }
//}

public class Bike
{
    public string Name;
    private double price;

    public void SetPrice(double price)
    {
        if (price <= 0)
            return;
        if (price >= 50_000)
            return;
        SetProfit();
    }
    private void SetProfit()
    {
        if (price >= 50_000 && price <= 100_000)
        {
            this.price = price;
            this.price = this.price * 1.1;
        }
        if (price >= 150_000 && price <= 150_000)
        {
            this.price = price;
            this.price = this.price * 1.2;
        }
        if (price >= 250_000 && price <= 500_000)
        {
            this.price = price;
            this.price = this.price * 1.3;
        }

    }
    public double GetPrice()
    {
        return price;
    }

}
