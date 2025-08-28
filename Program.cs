using EF_Asmnt2.Data;
using EF_Asmnt2.Model;

namespace EF_Asmnt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using ItiDbContext dbContext = new ItiDbContext();

            #region CRUD
            #region Add Data
            #region Department
            //List<Department> departments = new List<Department>()
            //{
            //    new Department { Name = "Computer Science", HiringDate = new DateOnly(2020, 1, 15) },
            //    new Department { Name = "Mathematics", HiringDate = new DateOnly(2019, 3, 10) },
            //    new Department { Name = "Physics", HiringDate = new DateOnly(2018, 5, 20) }
            //};
            //dbContext.Departments.AddRange(departments);
            //dbContext.SaveChanges();



            #endregion
            #region Instructor
            //List<Instructor> instructors=new List<Instructor>()
            //{
            //    new Instructor(){ Name="John Doe", Salary=60000, Address="123 Main St", HourRateBonus=50, Dep_Id=1 },
            //    new Instructor(){ Name="Jane Smith", Salary=65000, Address="456 Oak Ave", HourRateBonus=60, Dep_Id=2 },
            //    new Instructor(){ Name="Mike Johnson", Salary=70000, Address="789 Pine Rd", HourRateBonus=70, Dep_Id=3 },
            //    new Instructor(){ Name="Sara Brown", Salary=72000, Address="321 Maple St", HourRateBonus=55, Dep_Id=1 },
            //    new Instructor(){ Name="Tom Wilson", Salary=68000, Address="654 Cedar Ave", HourRateBonus=65, Dep_Id=2 },
            //    new Instructor(){ Name="Emma Davis", Salary=75000, Address="987 Birch Rd", HourRateBonus=75, Dep_Id=3 }
            //    };
            //dbContext.Instructors.AddRange(instructors);
            //dbContext.SaveChanges();
            #endregion
            #region Topic
            //List<Topic> topics = new List<Topic>()
            //{
            //new Topic(){ Name="C#"},
            //new Topic(){ Name="Java"},
            //new Topic(){ Name="Python"},
            //new Topic(){ Name="JavaScript"},
            //new Topic(){ Name="SQL"},
            //new Topic(){ Name="HTML"},
            //};
            //dbContext.Topics.AddRange(topics);
            //dbContext.SaveChanges();
            #endregion
            #region Courses
            //List<Course> courses = new List<Course>()
            //{
            // new Course(){ Name="C# Basics", Duration=40, Description="Introduction to C#", Top_Id=1 },
            // new Course(){ Name="Advanced Java", Duration=60, Description="Deep dive into Java", Top_Id=2 },
            // new Course(){ Name="Python for Data Science", Duration=50, Description="Using Python in Data Science", Top_Id=3 },
            // new Course(){ Name="JavaScript Essentials", Duration=45, Description="Core concepts of JavaScript", Top_Id=4 },
            // new Course(){ Name="SQL Fundamentals", Duration=30, Description="Basics of SQL", Top_Id=5 },
            // new Course(){ Name="HTML & CSS", Duration=35, Description="Web design with HTML & CSS", Top_Id=6 }
            //};
            //dbContext.Courses.AddRange(courses);
            //dbContext.SaveChanges();

            #endregion

            #endregion
            #region Read Data
            #region Department
            //var departments = dbContext.Departments.Where(D => D.Id > 1);
            //foreach (var dept in departments)
            //{
            //    Console.WriteLine($"Department ID: {dept.Id}, Name: {dept.Name}, Hiring Date: {dept.HiringDate}");
            //}
            #endregion
            #region Instructors
            //var Instructors = dbContext.Instructors.Where(I => I.Salary > 70000);
            //foreach(var instructor in Instructors) {
            //    Console.WriteLine($"Instructor ID: {instructor.Id}, Name: {instructor.Name}, Salary: {instructor.Salary}, Address: {instructor.Address}, Hour Rate Bonus: {instructor.HourRateBonus}, Department ID: {instructor.Dep_Id}");
            //}

            #endregion
            #region Topic
            //var topics = dbContext.Topics.Where(T => T.Name.StartsWith("J"));
            //foreach (var topic in topics)
            //{
            //    Console.WriteLine($"Topic ID: {topic.Id}, Name: {topic.Name}");
            //}
            #endregion
            #region Courses
            //var courses = dbContext.Courses.Where(C => C.Duration < 45);
            //foreach (var course in courses)
            //{
            //    Console.WriteLine($"Course ID: {course.Id}, Name: {course.Name}, Duration: {course.Duration}, Description: {course.Description}, Topic ID: {course.Top_Id}");
            //}
            #endregion
            #endregion
            #region Update
            #region Department
            //var dep = dbContext.Departments.FirstOrDefault(D => D.Id == 1);
            //if (dep is not null)
            //{
            //    dep.Ins_Id = 1;
            //    dbContext.SaveChanges();
            //}
            #endregion
            #region Instructors
            //var ins = dbContext.Instructors.FirstOrDefault(I => I.Salary < 750000);
            //if(ins is not null)
            //{
            //    ins.Salary = 80000;
            //    dbContext.SaveChanges();
            //}
            #endregion
            #region Topic
            //var topic =dbContext.Topics.First();
            //topic.Name= "COOL";
            //dbContext.SaveChanges();
            #endregion
            #region Courses
            //var course = dbContext.Courses.FirstOrDefault(C => C.Id == 1);
            //if (course is not null)
            //{
            //    course.Duration = 50;
            //    dbContext.SaveChanges();
            //}
            #endregion
            #endregion

            #region Delete Data
            #region Department
            //var Depts = dbContext.Departments.Where(D => D.Id > 3);
            //dbContext.RemoveRange(Depts);
            //dbContext.SaveChanges();
            #endregion
            #region Instructors
            //var Instructors = dbContext.Instructors.Select(I => I.Salary > 73000);
            //dbContext.RemoveRange(Instructors);
            #endregion
            #region Topic
            //var topics = dbContext.Topics.Where(T => T.Name.StartsWith("J"));
            //dbContext.RemoveRange(topics);
            //dbContext.SaveChanges();
            #endregion
            #region Courses
            //var courses = dbContext.Courses.Where(C => C.Duration > 50);
            //dbContext.RemoveRange(courses);
            //dbContext.SaveChanges();
            #endregion
            #endregion
            #endregion
        }
    }
}
