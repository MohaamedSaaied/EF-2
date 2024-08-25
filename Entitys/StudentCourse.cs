using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class StudentCourse
    {
        public int Stud_id { get; set; }
        public int Course_id { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
        public double Grade { get; set; }
    }
}
