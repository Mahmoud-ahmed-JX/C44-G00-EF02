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
    internal class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(S=>S.Department)
                .WithMany(D=>D.Students)
                .HasForeignKey(S=>S.Dep_Id)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
