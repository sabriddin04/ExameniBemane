using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IStudentService
{
    Task<List<Students>> GetStudents();
    Task AddStudent(Students student);
    Task UpdateStudent(Students student);
    Task DeleteStudent(int studentId);
    Task<StudentAtendances> GetStudentAtendances(int studentId);

}
