using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class Department
    {
        public int id { get; set; }

        public string Name { get; set; }
        public Student Student { get; set; }

        public ICollection<InstructorDepartments> DepartmentsInstructor { get; set; }=new HashSet<InstructorDepartments>();
        //public Instructor Instructor {  get; set; }
        //public int Ins_id { get; set; }
        public DateTime Hire_Date { get; set; }
    }
}
