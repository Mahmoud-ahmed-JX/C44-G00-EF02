using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EF_Asmnt2.Model;
namespace EF_Asmnt2.Data
{
    internal class ItiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ItiDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        DbSet<Student> Students { get; set; }
        DbSet<Course> Courses { get; set; }
        DbSet<Department> Departments { get; set; }
        
        DbSet<Instructor> Instructors { get; set; }

        DbSet<Topic> Topics { get; set; }
        DbSet<Stud_Course> St_Crs { get; set; }
        DbSet<Course_Inst> Crs_Ins { get; set; }
        
    }
}
