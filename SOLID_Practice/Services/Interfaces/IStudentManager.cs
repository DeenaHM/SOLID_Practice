using SOLID_Practice.Models;

namespace SOLID_Practice.Services.Interfaces;
internal interface IStudentManager
{
    void AddStudent(Student student);
    void RemoveStudent(int studentId);
    List<Student> GetAllStudents();
}
