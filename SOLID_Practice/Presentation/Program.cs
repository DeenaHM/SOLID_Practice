using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SOLID_Practice.Application.Services;
using SOLID_Practice.Core.Entities;
using SOLID_Practice.Core.Interfaces;

namespace SOLID_Practice.Presentation
{
    public class Program
    {
        static async Task Main(string[] args)
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
            var contractEmployeeManager = serviceProvider.GetService<IRemovableEmployeeManager>();
            var regularEmployeeManager = serviceProvider.GetService<IEmployeeManager>();


            Operations.Students(studentManager, courseManager);
            Operations.Employees(regularEmployeeManager, contractEmployeeManager);
        }


    
    }
}
