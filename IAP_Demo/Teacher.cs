using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP_Demo
{
    public class Teacher : Person
    {
        public Teacher (string name, bool gender) : base (name, gender)
        {
        }
        public override string JobTitle()
        {
            return "I am teacher";
        }
    }
}
