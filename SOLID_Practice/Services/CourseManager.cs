using SOLID_Practice.Models;
using SOLID_Practice.Services.Interfaces;

public class CourseManager : ICourseManager
{
    private readonly List<Course> _courses = new List<Course>();

    List<Course> ICourseManager.GetAllCourses()
    {
        return _courses;
    }
    void ICourseManager.AddCourse(Course course)
    {
        _courses.Add(course);
    }
    public void RemoveCourse(string courseCode)
    {
        var course = _courses.FirstOrDefault(c => c.Code == courseCode);
        if (course != null)
        {
            _courses.Remove(course);
        }
    }
}