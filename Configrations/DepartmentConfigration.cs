using EF_Asmnt2.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Asmnt2.Configrations
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            builder.HasOne<Instructor>()
                .WithOne()
                .HasForeignKey<Department>(D=>D.Ins_Id)
                .OnDelete(DeleteBehavior.NoAction);
           
        }
    }
}
