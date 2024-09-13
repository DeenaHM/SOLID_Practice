using SOLID_Practice.Core.Entities;
using SOLID_Practice.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Application.Services;
public class ContractEmployeeManager : IRemovableEmployeeManager
{
    private readonly List<Employee> _employees = new List<Employee>();
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }

    public void RemoveEmployee(int employeeId)
    {
        var employee = _employees.FirstOrDefault(e => e.Id == employeeId);
        if (employee != null)
        {
            _employees.Remove(employee);
        }
    }

    public List<Employee> GetAllEmployees()
    {
        return _employees;
    }
}
