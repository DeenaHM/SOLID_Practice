using SOLID_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Services.Interfaces;
internal interface IEmployeeManager
{
    void AddEmployee(Employee employee);
    List<Employee> GetAllEmployees();
}
