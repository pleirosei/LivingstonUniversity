using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LivingstonUniversity.Models;

namespace LivingstonUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student> 
            {
                new Student{FirstMidName="Sean",LastName="Livingston",EnrollmentDate=DateTime.Parse("2014-10-01")},
                new Student{FirstMidName="Sean",LastName="Armbrister",EnrollmentDate=DateTime.Parse("2014-03-15")},
                new Student{FirstMidName="Nicole",LastName="Livingston",EnrollmentDate=DateTime.Parse("2014-02-13")},
                new Student{FirstMidName="Joanna",LastName="Livingston",EnrollmentDate=DateTime.Parse("2014-03-02")},
                new Student{FirstMidName="Adoniah",LastName="Livingston",EnrollmentDate=DateTime.Parse("2014-02-02")}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID=1050,Title="Gaming",Credits=3,},
                new Course{CourseID=1480,Title="Physics",Credits=3,},
                new Course{CourseID=4140,Title="Economics",Credits=3,},
                new Course{CourseID=2850,Title="Gain Customers", Credits=3,}
            };
            
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=1480,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4140,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=2850,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=2,CourseID=1480,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=4140,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=2850,Grade=Grade.A},
                new Enrollment{StudentID=3,CourseID=1050,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=1480,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=4140,Grade=Grade.B},
                new Enrollment{StudentID=3,CourseID=2850,Grade=Grade.A},
                new Enrollment{StudentID=4,CourseID=1050,Grade=Grade.B},
                new Enrollment{StudentID=4,CourseID=1480,Grade=Grade.C},
                new Enrollment{StudentID=4,CourseID=4140,Grade=Grade.B},
                new Enrollment{StudentID=4,CourseID=2850,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=1480,Grade=Grade.B},
                new Enrollment{StudentID=5,CourseID=4140,Grade=Grade.A},
                new Enrollment{StudentID=5,CourseID=2850,Grade=Grade.A}
            };

            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}