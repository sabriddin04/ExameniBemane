using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IClassroomStudentService
{
    Task<List<ClassroomStudents>> GetClassroomStudents();
    Task AddClassroomStudent(ClassroomStudents classroomStudent);
    Task UpdateClassroomStudent(ClassroomStudents classroomStudent);
    Task DeleteClassroomStudent(int classroomStudentId);
}
