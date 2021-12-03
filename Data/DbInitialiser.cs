
using ASP_RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASP_RazorContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddStudents(context);
            AddCourses(context);
            AddEnrollments(context);
            AddModules(context);

        }

        private static void AddStudents(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Carson",LastName="Alexander",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Meredith",LastName="Alonso",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Arturo",LastName="Anand",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Gytis",LastName="Barzdukas",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Yan",LastName="Li",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Peggy",LastName="Justice",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Laura",LastName="Norman",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Nino",LastName="Olivetto",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();

        }


        private static void AddCourses(ApplicationDbContext context)
        {
            if (context.Courses.Any())
            {
                return; // db has been seeded
            }

            var courses = new Course[]
            {
                new Course{CourseID=1050,CourseCode="BT1CTG1",Title="Web Development",},
                new Course{CourseID=4022,CourseCode="BT1CTG3",Title="Computing",},
                new Course{CourseID=4041,CourseCode="BT1CTG6",Title="Software Engineering",},
                new Course{CourseID=1045,CourseCode="BT1CTG2",Title="Cyber Security",},
                new Course{CourseID=3141,CourseCode="BT1CTG7",Title="Archetecural Technology",},
                new Course{CourseID=2021,CourseCode="BT1CTG9",Title="Accounting and Finance",},
                new Course{CourseID=2042,CourseCode="BT1CTG0",Title="Air Transport",}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();

        }


        private static void AddEnrollments(ApplicationDbContext context)
        {
            if (context.Enrollments.Any())
            {
                return;
            }

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grades.A},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grades.B},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID=1045},
                new Enrollment{StudentID=7,CourseID=3141,Grade=Grades.A},
            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }

        private static void AddModules(ApplicationDbContext context)
        {
            if (context.Modules.Any())
            {
                return;
            }

            var modules = new Module[]
            {
                new Module
                {
                    ModuleID="CO550",
                    Title="Web Applications",
                    Courses = new List<Course> {}
                },
                new Module
                {
                    ModuleID="CO558",
                    Title="Database Design",
                    Courses = new List<Course> {}
                },
                new Module
                {
                    ModuleID="CO567",
                    Title="OO Systems Development",
                    Courses = new List<Course> {}
                },
                new Module
                {
                    ModuleID= "CO566", 
                    Title="Mobile Systems",
                    Courses = new List<Course> {}
                },
            };

            context.Modules.AddRange(modules);
            context.SaveChanges();


        }
    }
}
