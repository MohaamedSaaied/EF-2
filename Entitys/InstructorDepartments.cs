using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class InstructorDepartments
    {
        public int Inst_id { get; set; }
        public int Dept_id { get; set; }
        public Instructor Instructor { get; set; }
        public Department Department { get; set; }
    }
}
