using EF_Asmnt2.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Configrations
{
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.HasOne(I=>I.DepartmentManages)
                   .WithMany(D=>D.Instructors)
                   .HasForeignKey(I => I.Dep_Id)
                   .OnDelete(DeleteBehavior.NoAction);
                   
        }
    }
}
