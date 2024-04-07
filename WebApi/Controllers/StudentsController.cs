
namespace WebApi.Controllers;

using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]
public class StudentsController(IStudentService studentService)
{
     
     [HttpGet("Gets-Students")]
    public async Task<List<Students>> GetStudents()
    {
        return await studentService.GetStudents();
    }

    [HttpPost("Add-Student")]

    public async Task AddStudent(Students student)
    {
        await studentService.AddStudent(student);
    }


    [HttpDelete("Delete-Student")]

    public async Task DeleteStudent(int studentId)
    {
        await studentService.DeleteStudent(studentId);
    }

    [HttpPut("Update-Student")]

    public async Task UpdateStudent(Students student)
    {
        await studentService.UpdateStudent(student);
    }
}

