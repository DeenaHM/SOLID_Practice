using System.Runtime.CompilerServices;

namespace SOLID_Practice.Core.Entities;
public class Employee : Person
{
    public string Department { get; set; }
    private List<PayItem> payItems { get; set; } = new();
    public Employee(int Id, string firstName, string lastName, int age, string email,
                    string department)
                  : base(Id, firstName, lastName, age, email)
    {
        Department = department;
    }


    // Overridden method Open/Closed Principle
    public override void DisplayInfo()
    {
        base.DisplayInfo(); // Call the base class method
        Console.WriteLine($"Employee ID: {Id}");
        Console.WriteLine($"Department: {Department}");
    }
    public void AddPayItem(PayItem item)
    {
        payItems.Add(item);
    }
    
}
