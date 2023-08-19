using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    public class Person
    {
        public Person(int id, string name, Animal animal)
        {
            Id = id;
            FullName = name;
            Pet = animal;
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public Animal Pet { get; set; }
    }
}
