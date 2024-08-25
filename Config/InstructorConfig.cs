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
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasKey(E => E.id);
            builder.HasMany(I => I.InstructorsDepartment).WithOne(ID => ID.Instructor).HasForeignKey(ID => ID.Inst_id).IsRequired();
            builder.HasMany(I=>I.InstructorCourses).WithOne(CI=>CI.Instructor).HasForeignKey(CI=>CI.Inst_id).IsRequired();
        }
    }
}
