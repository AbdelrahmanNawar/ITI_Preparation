internal class Program
{
    private static void Main(string[] args)
    {
        ClassName obj1 = new ClassName();
        ClassName obj2 = new ClassName();
        obj1.FirstName = "Test";
        obj2.Id = 1;

        Circle circle = new Circle(10);
        circle.Radius = 10;
    }
}

public class Circle
{
    //static
    //readonly
    //const

    public const double pi1 = 3.14;
    public readonly double pi2;

    public Circle(double radius)
    {
        Radius = radius;
        //pi2 = 3.14;
    }

    public double Radius { get; set; }
    public double CalculateArea()
    {
        return Radius * Radius * pi;
    }
    public double CalculateCircumference()
    {
        return Radius * pi;
    }
}

public class ClassName
{
    public ClassName()
    {

    }
    static ClassName()
    {
        Definition = "First call to the class, i call the static Constructor.";
        PrintDefinition();
    }
    public string FirstName { get; set; }
    public int Id { get; set; }

    public static string Definition { get; set; }

    public static void PrintDefinition()
    {
        Console.WriteLine(Definition);
    }
}