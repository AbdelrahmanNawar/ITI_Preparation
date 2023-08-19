using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAP_Demo
{
    public class College
    {
        private College()
        {
            Teachers = new List<Teacher>();
            Students = new List<Student>();
            Courses = new List<Course>();
        }

        public static College GetCollege()
        {
            if(college == null)
            {
                college = new College();
            }
            return college;
        }

        public void pro() { }

        private static College college;
        public string CollegeName { get; }
        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }
        public List<Course> Courses { get; set; }

        public int X { get; set; }
        public static int Y { get; set; }
    }
}
