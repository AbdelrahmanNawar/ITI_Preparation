// id
// name
// tetba3 hi {} : meow
using System.Xml.Linq;

namespace ClassDemo
{
    public partial class Cat : Animal
    {
        public Cat()
        {

        }
        public Cat(string name, int id) : base(id, name) // new Animal(id, name)
        {
            ASD = name;
        }

        public string Hamada1 { get; set; }
        protected int AAA;
        public void printf(bool isMeow = false)
        {
            if (!isMeow)
            {
                Console.WriteLine($"Name= {Name}, ID= {ID}");
            }
            else
            {
                Console.WriteLine($"Hi {Name}, Meaow");
            }
        }

        public override string ConvertObjectToString()
        {
            return $"ID: {ID}, Name: {Name}. Hello Cat";
        }
    }

    public partial class Cat : Animal
    {
        public int Hamada2 { get; set; }
    }

}

