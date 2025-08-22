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
    internal class Course_InstConfigration : IEntityTypeConfiguration<Model.Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.HasKey(CI => new {CI.Inst_Id, CI.Course_Id });

            builder.HasOne<Instructor>()
                .WithMany()
                .HasForeignKey(CI => CI.Inst_Id)
                .OnDelete(DeleteBehavior.Restrict);
           
            builder.HasOne<Course>()
                .WithMany()
                .HasForeignKey(CI => CI.Course_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
