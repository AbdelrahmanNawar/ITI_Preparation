using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP_Demo
{
    public class Student : Person
    {
        public Student (string name, bool gender) : base(name, gender)
        {
        }
        public override string JobTitle()
        {
            return "I am student";
        }
    }
}
