using ClassDemo;

internal class Program
{
    public static void Main(string[] args)
    {
        //double area =  MathBase.CalculateCircleArea(4);


        Cat Kajo= new Cat("Kajo", 4273);
        Dog sultan = new Dog("Sultan", 2871, true);
        Sel3awa sel = new Sel3awa(789463512, "rfvygbjhn", 6);

        //Console.WriteLine(Kajo.ConvertObjectToString());
        //Console.WriteLine(sultan.ConvertObjectToString());
        //Console.WriteLine(sel.ConvertObjectToString());

        Person yara = new Person(4273, "yara nawar", Kajo);
        Animal roro = new Animal(123,"Ro ro");
        RORO(Kajo);
        RORO(sultan);
        RORO(sel);
        RORO(roro);

        int xx = 0;
        Animal x = Kajo;
        Cat y = (Cat)roro;
        RORO(x);

        object o1 = xx;
        object o2 = Kajo;

        xx = (int)o2;

        //Console.WriteLine(yara.Pet.ConvertObjectToString());
        //Console.WriteLine(Kajo.ConvertObjectToString());

        //Animal Batates = new Cat();
        //Batates.Name = "Batates";
        //Batates.ID = 4077;

        //Batates.printf(true);
        //Batates.printf(false);
        //Kajo.printf(true);
        //Kajo.printf(false);



        Console.WriteLine("================");
        //Dog alex = new Dog("Alex", 4263, false);
        //Console.WriteLine("================");
        //Dog osman = new Dog("Alex", 4263, false);
        //Dog.PrintCount();
    }

    public static void RORO(Animal animal)
    {
        Console.WriteLine(animal.ConvertObjectToString());
    }
}