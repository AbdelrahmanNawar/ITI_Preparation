using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Dog : Animal
    {
        public Dog(string name, int id, bool isDangerous) : base(id, name)
        {
            StaticCount = StaticCount + 1;
            IsDangerous = isDangerous;
        }

        public static int StaticCount = 0;

        public bool IsDangerous { get; set; }

        public void PrintF()
        {
            if (IsDangerous)
            {
                Console.WriteLine($"Name= {Name}, ID= {ID}");
            }
            else
            {
                Console.WriteLine($"Hi {Name}, Haw");
            }
        }

        public static void PrintCount()
        {
            Console.WriteLine($"static = {StaticCount}");
        }

        public override string ConvertObjectToString()
        {
            return $"ID: {ID}, Name: {Name}, is dangerous {IsDangerous}. Hello Dog";
        }
    }
}
