internal class Program
{
    private static void Main(string[] args)
    {
        Cat c = new Cat();
        Doctor d = new Doctor();

        DoBehaviourThings(c);
        DoBehaviourThings(d);
    }

    public static void DoBehaviourThings(IBehaviour behaviour)
    {
        behaviour.Eat();
        behaviour.Sleep();
        behaviour.BEBE();
    }
}

public abstract class Animal
{

}
public abstract class Person
{

}
public interface IPayment
{
    public void PayRent()
    {

    }
    public void PayCar();
    public void PayBills();
}
public interface IBehaviour
{
    public void Eat();
    public void BEBE();
    public void Sleep();
}

public class Cat : Animal, IBehaviour
{
    public void BEBE()
    {
        throw new NotImplementedException();
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }
}
public class Doctor : Person, IBehaviour, IPayment
{
    public int Id { get; set; }
    public Cat Cat { get; set; }
    // composition vs aggregation vs association
    public void BEBE()
    {
        throw new NotImplementedException();
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }

    public void Sleep()
    {
        throw new NotImplementedException();
    }

    public void PayBills()
    {
        throw new NotImplementedException();
    }

    public void PayCar()
    {
        throw new NotImplementedException();
    }

    public void PayRent()
    {
        throw new NotImplementedException();
    }
}