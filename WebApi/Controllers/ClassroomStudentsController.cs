using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]

public class ClassroomStudentsController(IClassroomStudentService classroomStudentService)
{
         [HttpGet("Gets-ClassroomStudent")]
    public async Task<List<ClassroomStudents>> GetClassroomStudent()
    {
        return await classroomStudentService.GetClassroomStudents();
    }

    [HttpPost("Add-Course")]

    public async Task AddCourse(ClassroomStudents classroomStudent)
    {
        await classroomStudentService.AddClassroomStudent(classroomStudent);
    }

    [HttpDelete("Delete-Course")]

    public async Task DeleteParent(int classroomStudentId)
    {
        await classroomStudentService.DeleteClassroomStudent(classroomStudentId);
    }

    [HttpPut("Update-Course")]

    public async Task UpdateParent(ClassroomStudents classroomStudent)
    {
        await classroomStudentService.UpdateClassroomStudent(classroomStudent);
    }
}
