using Domain;
using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]

public class ExamTypeController(IExamTypeService examTypeService)
{
    
        [HttpGet("Gets-ExamTypes")]
    public async Task<List<ExamType>> GetExamTypes()
    {
        return await examTypeService.GetExamTypes();
    }

    [HttpPost("Add-ExamType")]

    public async Task AddExamType(ExamType examType)
    {
        await examTypeService.AddExamType(examType);
    }

    [HttpDelete("Delete-ExamType")]

    public async Task DeleteExamType(int examTypeId)
    {
        await examTypeService.DeleteExamType(examTypeId);
    }

    [HttpPut("Update-ExamType")]

    public async Task UpdateExamType(ExamType examType)
    {
        await examTypeService.UpdateExamType(examType);
    }
}
