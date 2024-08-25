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
    internal class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(C=>C.id);
            builder.HasOne(C => C.Topic).WithOne(T => T.Course).HasForeignKey<Course>(C => C.Top_id);
            builder.HasMany(C => C.CourseStudents).WithOne(SC => SC.Course).HasForeignKey(SC => SC.Course_id).IsRequired();
            builder.HasMany(C => C.CourseInstructors).WithOne(CI => CI.Course).HasForeignKey(CI => CI.Course_id).IsRequired();
        }
    }
}
