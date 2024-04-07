using Domain.Models;

namespace Infrastructure.Interfaces;

public interface ITeacherService
{

     Task<List<Teachers>> GetTeachers();
    Task AddTeacher(Teachers teacher);
    Task UpdateTeacher(Teachers teacher);
    Task DeleteTeacher(int teacherId);
}
