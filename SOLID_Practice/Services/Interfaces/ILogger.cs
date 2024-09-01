using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Practice.Services.Interfaces;
internal interface ILogger
{
    void LogInformation(string message);
    void LogWarning(string message);
    void LogError(string message);
}
