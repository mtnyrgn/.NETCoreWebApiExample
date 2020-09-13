using Data.StudentData;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.StudentData
{
    public class StudentMap
    {
        public StudentMap(EntityTypeBuilder<Student> entityBuilder)
        {
            entityBuilder.HasKey(hk => hk.Id);
            entityBuilder.HasIndex(p => p.StudentIdentityNumber).IsUnique(); //Student number must be unique!
            entityBuilder.Property(p => p.Name);
            entityBuilder.Property(p => p.Surname);
            entityBuilder.Property(p => p.Address);
            entityBuilder.Property(p => p.Email);
            entityBuilder.Property(p => p.Phone);
            entityBuilder.Property(p => p.isDelete);
        }
    }
}
