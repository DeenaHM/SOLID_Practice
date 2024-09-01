namespace SOLID_Practice.Models;
internal class Student : Person // Open/Closed Principle (OCP) 
{
    public double GPA { get; set; }

    public Student(int Id ,string firstName, string lastName, int age, string email, int id, double gPA)
                  : base(Id, firstName, lastName, age, email)
    {
        GPA = gPA;
    }

    // Overridden method
    public override void DisplayInfo()//(OCP) 
    {
        base.DisplayInfo(); // Call the base class method
        Console.WriteLine($"Student ID: {Id}");

        Console.WriteLine($"GPA: {GPA}");
    }

}
