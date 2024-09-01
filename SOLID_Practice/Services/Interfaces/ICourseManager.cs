using SOLID_Practice.Models;

namespace SOLID_Practice.Services.Interfaces;
internal interface ICourseManager
{
    void AddCourse(Course course);
    void RemoveCourse(string courseCode);
    List<Course> GetAllCourses();
}
