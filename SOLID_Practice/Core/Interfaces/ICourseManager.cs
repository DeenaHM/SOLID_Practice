using SOLID_Practice.Core.Entities;

namespace SOLID_Practice.Core.Interfaces;
public interface ICourseManager
{
    void AddCourse(Course course);
    void RemoveCourse(string courseCode);
    List<Course> GetAllCourses();
}
