using SOLID_Practice.Core.Entities;
using SOLID_Practice.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice;
public static class Operations
{
    public static void Students(IStudentManager? studentManager, ICourseManager? courseManager)
    {
        //Liskov Substitution Principle
        Person studentLiskov = new Student(1, "Ali", "Ahmad", 20, "ali.ahmad@example.com", 1, 3.5);
        Person employee = new Employee(2, "Sara", "Mohammad", 22, "sara.mohammad@example.com", "IT");



        // Add Students
        studentManager!.AddStudent((Student)studentLiskov);
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
    }

    public static void Employees(IEmployeeManager? regularEmployeeManager, IRemovableEmployeeManager? contractEmployeeManager)
    {
        var regularEmployee = new Employee(1, "Ahmad", "Ali", 30, "ahmad.ali@gmail.com", "IT");
        regularEmployeeManager?.AddEmployee(regularEmployee);

        var contractEmployee = new Employee(2, "Noor", "Hassan", 28, "Noor@gmail.com", "HR");
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
    }

}
