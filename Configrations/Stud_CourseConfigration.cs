using EF_Asmnt2.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Configrations
{
    internal class Stud_CourseConfigration : IEntityTypeConfiguration<Model.Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.HasKey(Sc => new { Sc.Stud_Id, Sc.Course_Id });
            builder.HasOne<Student>()
                 .WithMany()
                 .HasForeignKey(st => st.Stud_Id)
                 .OnDelete(DeleteBehavior.Restrict)
                 ;


            builder.HasOne<Course>()
                 .WithMany()
                 .HasForeignKey(cr => cr.Course_Id)
                 .OnDelete(DeleteBehavior.Restrict);


        }
    }
}
