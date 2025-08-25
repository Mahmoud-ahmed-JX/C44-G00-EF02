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
    internal class CourseConfigration : IEntityTypeConfiguration<Model.Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasIndex(C=>C.Name).IsUnique();
            builder.HasOne(C=>C.Topic)
                 .WithMany(T=>T.Courses)
                 .HasForeignKey(C=>C.Top_Id)
                 .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
