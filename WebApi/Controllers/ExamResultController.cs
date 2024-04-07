using Domain;
using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]
public class ExamResultController(IExamResultService examResultService)
{
        [HttpGet("Gets-ExamResult")]
    public async Task<List<ExamResult>> GetExamResults()
    {
        return await examResultService.GetExamResults();
    }

    [HttpPost("Add-ExamResult")]

    public async Task AddExamResult(ExamResult examResult)
    {
        await examResultService.AddExamResult(examResult);
    }

    [HttpDelete("Delete-ExamResult")]

    public async Task DeleteExamResult(int examResultId)
    {
        await examResultService.DeleteExamResult(examResultId);
    }

    [HttpPut("Update-ExamResult")]

    public async Task UpdateExamResult(ExamResult examResult)
    {
        await examResultService.UpdateExamResult(examResult);
    }
}
