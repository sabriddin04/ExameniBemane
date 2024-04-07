namespace WebApi.Controllers;

using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]
public class TeachersContoller(ITeacherService teacherService)
{
      [HttpGet("Gets-Teachers")]
    public async Task<List<Teachers>> GetTeachers()
    {
        return await teacherService.GetTeachers();
    }

    [HttpPost("Add-Teacher")]

    public async Task AddTeacher(Teachers teacher)
    {
        await teacherService.AddTeacher(teacher);
    }


    [HttpDelete("Delete-Teacher")]

    public async Task DeleteTeacher(int teacherId)
    {
        await teacherService.DeleteTeacher(teacherId);
    }

    [HttpPut("Update-Teacher")]

    public async Task UpdateTeacher(Teachers teacher)
    {
        await teacherService.UpdateTeacher(teacher);
    }
}
