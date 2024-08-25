using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class CourseInstructor
    {
        public int Inst_id { get; set; }
        public int Course_id { get; set; }
        public Instructor Instructor { get; set; }
        public Course Course { get; set; }
        public string Evaluation { get; set; }
    }
}
