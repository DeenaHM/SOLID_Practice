using SOLID_Practice.Models;
using SOLID_Practice.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Services;
internal class RegularEmployeeManager : IEmployeeManager
{
    private readonly List<Employee> _employees = new List<Employee>();

    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public List<Employee> GetAllEmployees()
    {
        return _employees;
    }
}
