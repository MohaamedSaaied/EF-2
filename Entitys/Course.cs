using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Entitys
{
    internal class Course
    {
        public int id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Topic Topic { get; set; }
        public int Top_id { get; set; }
        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();
        public ICollection<CourseInstructor> CourseInstructors { get; set; } = new HashSet<CourseInstructor>();

    }
}
