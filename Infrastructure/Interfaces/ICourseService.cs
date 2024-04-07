using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ICourseService
{
    
    Task<List<Courses>> GetCourses();
    Task AddCourse(Courses course);
    Task UpdateCourse(Courses course);
    Task DeleteCourse(int courseId);
}
