using SOLID_Practice.Models;
using SOLID_Practice.Services.Interfaces;
namespace SOLID_Practice.Services;
internal class StudentManager : IStudentManager
{
    private readonly List<Student> _students = new List<Student>();
    private readonly ILogger _logger;

    public StudentManager(ILogger logger)
    {
        _logger = logger;
    }

    public List<Student> GetAllStudents()
    {
        _logger.LogInformation("Retrieving all students.");
        return _students;
    }
    public void AddStudent(Student student)
    {

       _students.Add(student);
        _logger.LogInformation($"Added student: {student.FirstName} {student.LastName}");

    }


    public void RemoveStudent(int studentId)
    {
        var student = _students.FirstOrDefault(s => s.Id == studentId);
        if (student != null)
        {
            _students.Remove(student);
            _logger.LogWarning($"Removed student: {student.FirstName} {student.LastName}");

        }
    }
}
