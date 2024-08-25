using EF_2.Config;
using EF_2.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EF_2
{
    internal class ITIContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        =>
        optionsBuilder.UseSqlServer("Server=.;Database=iti4;Trusted_Connection=True;TrustServerCertificate=True;");
        //public DbSet<Student> Students { get; set; } 
        public ITIContext() : base() { }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new InstructorConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfiguration(new StudentConfig());
            modelBuilder.ApplyConfiguration(new CourseConfig());
            modelBuilder.ApplyConfiguration(new StudentCourseConfig());
            modelBuilder.ApplyConfiguration(new CourseInstructorConfig());
            modelBuilder.ApplyConfiguration(new InstructorDepartmentConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}


