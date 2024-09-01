using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using SOLID_Practice.Models;
using SOLID_Practice.Services;
using SOLID_Practice.Services.Interfaces;

namespace SOLID_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set up DI Container
            var serviceProvider = new ServiceCollection()
                .AddScoped<IStudentManager, StudentManager>()
                .AddScoped<ICourseManager, CourseManager>()
                .AddScoped<IEmployeeManager, RegularEmployeeManager>()
                .AddScoped<IRemovableEmployeeManager, ContractEmployeeManager>()
                .AddSingleton<ILogger, Logger>()
                .BuildServiceProvider();

            var studentManager = serviceProvider.GetService<IStudentManager>();
            var courseManager = serviceProvider.GetService<ICourseManager>();
            var contractEmployeeManager = serviceProvider.GetService<IRemovableEmployeeManager>() ;
            var regularEmployeeManager = serviceProvider.GetService<IEmployeeManager>();

            #region StudentCurses

            //Liskov Substitution Principle
            Person studentLiskov = new Student(1, "Ali", "Ahmad", 20, "ali.ahmad@example.com", 1, 3.5);
            Person employee = new Employee(2, "Sara", "Mohammad", 22, "sara.mohammad@example.com", "IT", 5000);



            // Add Students
            studentManager.AddStudent((Student)studentLiskov);
            studentManager.AddStudent(new Student(2, "Sara", "Mohammad", 22, "sara.mohammad@example.com", 2, 3.8));

            // Add Courses
            courseManager.AddCourse(new Course { Id = 1, Code = "CS101", Title = "Computer Science 101" });
            courseManager.AddCourse(new Course { Id = 2, Code = "CS102", Title = "Computer Science 102" });

            // Display All Students
            Console.WriteLine("Students:");
            foreach (var student in studentManager.GetAllStudents())
            {
                student.DisplayInfo();
                Console.WriteLine();
            }

            // Display All Courses
            Console.WriteLine("Courses:");
            foreach (var course in courseManager.GetAllCourses())
            {
                course.DisplayInfo();
                Console.WriteLine();
            }

            //Remove Student and Course
            studentManager.RemoveStudent(1);
            courseManager.RemoveCourse("CS101");

            // Display All Students After Removal
            Console.WriteLine("Students After Removal:");
            foreach (var student in studentManager.GetAllStudents())
            {
                student.DisplayInfo();
                Console.WriteLine();
            }

            Console.WriteLine("Courses After Remove Courses:");
            foreach (var course in courseManager.GetAllCourses())
            {
                course.DisplayInfo();
                Console.WriteLine();
            }

            #endregion

            #region Employees
            var regularEmployee = new Employee(1, "Ahmad", "Ali", 30, "ahmad.ali@gmail.com", "IT", 5000);
            regularEmployeeManager?.AddEmployee(regularEmployee);

            var contractEmployee = new Employee(2, "Noor", "Hassan", 28, "Noor@gmail.com", "HR", 4000);
            contractEmployeeManager?.AddEmployee(contractEmployee);

            Console.WriteLine("All Employees:");
            foreach (var emp in regularEmployeeManager?.GetAllEmployees() ?? new List<Employee>())
            {
                emp.DisplayInfo();
                Console.WriteLine();
            }

            foreach (var emp in contractEmployeeManager?.GetAllEmployees() ?? new List<Employee>())
            {
                emp.DisplayInfo();
                Console.WriteLine();
            }
            //Remove Contract Employee 
            contractEmployeeManager?.RemoveEmployee(2);
            // regularEmployee.RemoveEmployee(2);   // Cant remove this employee 


            Console.WriteLine("Employees After Removal:");
            foreach (var emp in regularEmployeeManager?.GetAllEmployees() ?? new List<Employee>())
            {
                emp.DisplayInfo();
                Console.WriteLine();
            }

            foreach (var emp in contractEmployeeManager?.GetAllEmployees() ?? new List<Employee>())
            {
                emp.DisplayInfo();
                Console.WriteLine();
            }
            #endregion
        }
    }
}
