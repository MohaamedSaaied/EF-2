﻿using EF_2.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_2.Config
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(E=>E.id);
            builder.HasMany(D => D.DepartmentsInstructor).WithOne(ID => ID.Department).HasForeignKey(ID=>ID.Dept_id);
        }
    }
}