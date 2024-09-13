using SOLID_Practice.Core.Interfaces;

namespace SOLID_Practice.Application.Services
{
    public class Logger : ILogger
    {
        public void LogInformation(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"Info:");
            Console.ResetColor();
            Console.WriteLine($"{message}");
        }

        public void LogWarning(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Warn: ");
            Console.ResetColor();
            Console.WriteLine($"{message}");

        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Error: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.ResetColor();
            Console.WriteLine($"{message}");

        }
    }
}
