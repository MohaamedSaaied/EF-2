using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class Instructor
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public int Salary { get; set; }
        public int Age { get; set; }
        public string Adress { get; set; }
        public double HoureRate { get; set; }
        //public Department Deptartment { get; set; }
        //public int Dept_id { get; set; }
        public ICollection<InstructorDepartments> InstructorsDepartment { get; set; } = new List<InstructorDepartments>();
        public ICollection<CourseInstructor> InstructorCourses { get; set; } = new HashSet<CourseInstructor>();
        
    }
}
