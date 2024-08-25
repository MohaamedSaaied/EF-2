using EF_2.Entitys;

namespace EF_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            ITIContext DB = new ITIContext();

            #region Add
            //Topic topic = new Topic() { Name = "CS" };
            //DB.Add(topic);
            //DB.SaveChanges();
            //Course course = new Course() { Duration="5 Month",Name="C#",Description= "Course Description",Top_id=1 };
            //DB.Add(course);
            //DB.SaveChanges();
            //Department department = new Department() { Name = "CS", Hire_Date = DateTime.Now };
            //DB.Add(department);
            //DB.SaveChanges();
            //Student student = new Student(){FName="ahmed",LName="gaber",Adress="addr",Age=28,Dept_id=1 };
            //DB.Add(student);
            //DB.SaveChanges();
            //Instructor instructor=new Instructor() {Name="sayed",Bouns=500,Salary=8000,Adress="adress",HoureRate=200 };
            //DB.Add(instructor);
            //DB.SaveChanges();
            //InstructorDepartments instructorDepartment = new InstructorDepartments() { Inst_id=1,Dept_id=1};
            //DB.Add(instructorDepartment);
            //DB.SaveChanges();
            //StudentCourse studentCourse = new StudentCourse() {Stud_id=1 ,Course_id = 1, Grade = 100 };
            //DB.Add(studentCourse);
            //DB.SaveChanges();
            //CourseInstructor courseInstructor = new CourseInstructor() {Inst_id=1,Course_id = 1, Evaluation = "10/10" };
            //DB.Add(courseInstructor);
            //DB.SaveChanges();
            #endregion

            #region Retrive ---error'Invalid object name 'Students' this is when i define the DBSET in the ITI Context class.'

            //var Student = (from S in DB.Students where S.id == 1 select S).FirstOrDefault();
            //Console.WriteLine(Student);

            #endregion

            #region Update ----same error of retriving

            //var Student = (from S in DB.Students where S.id == 1 select S).FirstOrDefault();
            //Student.Adress = "new adress";
            //DB.SaveChanges();

            #endregion

            #region Delete ----same error of retriving

            //Topic topic = new Topic() { Name = "CS" };
            //DB.Add(topic);
            //DB.SaveChanges();
            //var Topic = (from S in DB.Topics where S.id == 2 select S).FirstOrDefault();
            //DB.Topics.Remove(Topic);
            //DB.SaveChanges();


            #endregion
        }
    }
}
