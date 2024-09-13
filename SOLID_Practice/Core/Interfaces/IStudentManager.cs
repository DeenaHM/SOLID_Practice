using SOLID_Practice.Core.Entities;

namespace SOLID_Practice.Core.Interfaces;
public interface IStudentManager
{
    void AddStudent(Student student);
    void RemoveStudent(int studentId);
    List<Student> GetAllStudents();
}
