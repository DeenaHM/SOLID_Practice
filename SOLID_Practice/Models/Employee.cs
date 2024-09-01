namespace SOLID_Practice.Models;
internal class Employee :Person
{
    public string Department { get; set; }
    public double Salary { get; set; }
    public Employee(int Id ,string firstName, string lastName, int age, string email,
                    string department, double salary)
                  : base(Id, firstName, lastName, age, email)
    {
        Department = department;
        Salary = salary;
    }

    // Overridden method Open/Closed Principle
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Call the base class method
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Department: {Department}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}
