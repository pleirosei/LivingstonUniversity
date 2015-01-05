namespace LivingstonUniversity.Migrations
{
    using LivingstonUniversity.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LivingstonUniversity.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LivingstonUniversity.DAL.SchoolContext context)
        {
            var students = new List<Student> 
            {
                new Student { FirstMidName = "Sean", LastName = "Livingston", EnrollmentDate = DateTime.Parse("2001-03-14") },
                new Student { FirstMidName = "Nicole", LastName = "Lynn", EnrollmentDate = DateTime.Parse("2002-03-20" )},
                new Student { FirstMidName = "Joanna", LastName = "Shaddai", EnrollmentDate = DateTime.Parse("2009-10-16" )},
                new Student { FirstMidName = "Adoniah", LastName = "James", EnrollmentDate = DateTime.Parse("2011-09-22" )},
                new Student { FirstMidName = "Sean", LastName = "Armbrister", EnrollmentDate = DateTime.Parse("2014-12-15" )}
            };
            students.ForEach(s => context.Students.AddOrUpdate(p => p.LastName, s));
            context.SaveChanges();

            var courses = new List<Course> 
            {
                new Course {CourseID = 4012, Title = "Get Good Gaming",      Credits = 3, },
                new Course {CourseID = 4073, Title = "Web Development",      Credits = 3, },
                new Course {CourseID = 4047, Title = "Software Development", Credits = 3, },
                new Course {CourseID = 4852, Title = "Security Programming", Credits = 3, },
                new Course {CourseID = 4321, Title = "Game Hacking",         Credits = 4, }   
            };
            courses.ForEach(s => context.Courses.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Livingston").ID,
                    CourseID = courses.Single(c => c.Title == "Get Good Gaming" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Livingston").ID,
                    CourseID = courses.Single(c => c.Title == "Web Development" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Livingston").ID,
                    CourseID = courses.Single(c => c.Title == "Software Development" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Livingston").ID,
                    CourseID = courses.Single(c => c.Title == "Security Programming" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Livingston").ID,
                    CourseID = courses.Single(c => c.Title == "Game Hacking" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lynn").ID,
                    CourseID = courses.Single(c => c.Title == "Get Good Gaming" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lynn").ID,
                    CourseID = courses.Single(c => c.Title == "Web Development" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lynn").ID,
                    CourseID = courses.Single(c => c.Title == "Software Development" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lynn").ID,
                    CourseID = courses.Single(c => c.Title == "Security Programming" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Lynn").ID,
                    CourseID = courses.Single(c => c.Title == "Game Hacking" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Shaddai").ID,
                    CourseID = courses.Single(c => c.Title == "Get Good Gaming" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Shaddai").ID,
                    CourseID = courses.Single(c => c.Title == "Web Development" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Shaddai").ID,
                    CourseID = courses.Single(c => c.Title == "Software Development" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Shaddai").ID,
                    CourseID = courses.Single(c => c.Title == "Security Programming" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Shaddai").ID,
                    CourseID = courses.Single(c => c.Title == "Game Hacking" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "James").ID,
                    CourseID = courses.Single(c => c.Title == "Get Good Gaming" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "James").ID,
                    CourseID = courses.Single(c => c.Title == "Web Development" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "James").ID,
                    CourseID = courses.Single(c => c.Title == "Software Development" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "James").ID,
                    CourseID = courses.Single(c => c.Title == "Security Programming" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "James").ID,
                    CourseID = courses.Single(c => c.Title == "Game Hacking" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Armbrister").ID,
                    CourseID = courses.Single(c => c.Title == "Get Good Gaming" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Armbrister").ID,
                    CourseID = courses.Single(c => c.Title == "Web Development" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Armbrister").ID,
                    CourseID = courses.Single(c => c.Title == "Software Development" ).CourseID,
                    Grade = Grade.B
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Armbrister").ID,
                    CourseID = courses.Single(c => c.Title == "Security Programming" ).CourseID,
                    Grade = Grade.A
                },
                new Enrollment {
                    StudentID = students.Single(s => s.LastName == "Armbrister").ID,
                    CourseID = courses.Single(c => c.Title == "Game Hacking" ).CourseID,
                    Grade = Grade.B
                }
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s => s.StudentID == e.StudentID &&
                    s.Course.CourseID == e.CourseID).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
