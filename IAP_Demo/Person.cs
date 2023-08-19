using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP_Demo
{
    public abstract class Person
    {
        public Person(string name, bool gender)
        {
            Name = name;
            Gender = gender;
        Courses = new List<Course>();
        }
        public List<Course> Courses { get; set; }
        public string Name { get; set; }
        public bool Gender { get; set; }

        public abstract string JobTitle();
    }
}
