namespace SOLID_Practice.Models;
internal class Course
{
    public int Id { get; set; }
    public string Code { get; set; }
    public string Title { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Course ID: {Id}");
        Console.WriteLine($"Course Code: {Code}");
        Console.WriteLine($"Course Title: {Title}");
    }
}

    //  Single Responsibility Principle (SRP) 
    // This ensures that each class focuses on one particular type of data,
    // in this case, Course information.