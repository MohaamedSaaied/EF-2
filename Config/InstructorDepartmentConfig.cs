using EF_2.Entitys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Config
{
    internal class InstructorDepartmentConfig : IEntityTypeConfiguration<InstructorDepartments>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<InstructorDepartments> builder)
        {
            builder.HasKey(ID => new {ID.Inst_id,ID.Dept_id});
        }
    }
}
