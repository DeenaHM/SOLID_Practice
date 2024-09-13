using SOLID_Practice.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Core.Interfaces;
public interface IEmployeeManager
{
    void AddEmployee(Employee employee);
    List<Employee> GetAllEmployees();
}
