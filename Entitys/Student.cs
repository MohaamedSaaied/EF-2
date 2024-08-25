using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class Student
    {
        public int id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public Department Department { get; set; }
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        public int Dept_id { get; set; }
    }
}
