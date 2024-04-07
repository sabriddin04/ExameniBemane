using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]
public class ClassroomsController(IClassroomService classroomService)
{
    [HttpGet("Gets-Classrooms")]
    public async Task<List<Classrooms>> GetClassrooms()
    {
        return await classroomService.GetClassrooms();
    }

    [HttpPost("Add-Classroom")]

    public async Task AddClassroom(Classrooms classroom)
    {
        await classroomService.AddClassroom(classroom);
    }


    [HttpDelete("Delete-Classroom")]

    public async Task DeleteClassroom(int classroomId)
    {
        await classroomService.DeleteClassroom(classroomId);
    }

    [HttpPut("Update-Classroom")]

    public async Task UpdateClassroom(Classrooms classroom)
    {
        await classroomService.UpdateClassroom(classroom);
    }
}
