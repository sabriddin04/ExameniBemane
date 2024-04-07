using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IClassroomService
{
    Task<List<Classrooms>> GetClassrooms();
    Task AddClassroom(Classrooms classroom);
    Task UpdateClassroom(Classrooms classroom);
    Task DeleteClassroom(int classroomId);
}
