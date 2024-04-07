using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]

public class GradeController(IGradeService gradeService)
{
    
        [HttpGet("Gets-Grades")]
    public async Task<List<Grade>> GetGrades()
    {
        return await gradeService.GetGrades();
    }

    [HttpPost("Add-Grade")]

    public async Task AddGrade(Grade grade)
    {
        await gradeService.AddGrade(grade);
    }

    [HttpDelete("Delete-Grade")]

    public async Task DeleteGrade(int gradeId)
    {
        await gradeService.DeleteGrade(gradeId);
    }

    [HttpPut("Update-Grade")]

    public async Task UpdateGrade(Grade grade)
    {
        await gradeService.UpdateGrade(grade);
    }

}
