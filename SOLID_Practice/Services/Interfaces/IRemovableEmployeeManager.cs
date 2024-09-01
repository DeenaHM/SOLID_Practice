﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Services.Interfaces;
internal interface IRemovableEmployeeManager : IEmployeeManager
{
    void RemoveEmployee(int employeeId);

}
