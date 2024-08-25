using EF_2.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Config
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(S => S.id);
            builder.HasOne(S=>S.Department).WithOne(D=>D.Student).HasForeignKey<Student>(S=>S.Dept_id);
            builder.HasMany(S => S.StudentCourses).WithOne(SC => SC.Student).HasForeignKey(SC=>SC.Stud_id).IsRequired();
            
        }
    }
}
