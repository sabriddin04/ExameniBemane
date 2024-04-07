using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]


public class CoursesController(ICourseService courseService) 
{
       [HttpGet("Gets-Courses")]
    public async Task<List<Courses>> GetCourses()
    {
        return await courseService.GetCourses();
    }

    [HttpPost("Add-Course")]

    public async Task AddCourse(Courses course)
    {
        await courseService.AddCourse(course);
    }

    [HttpDelete("Delete-Course")]

    public async Task DeleteParent(int courseId)
    {
        await courseService.DeleteCourse(courseId);
    }

    [HttpPut("Update-Course")]

    public async Task UpdateParent(Courses course)
    {
        await courseService.UpdateCourse(course);
    }

}
