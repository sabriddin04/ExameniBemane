using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]

public class ExamController(IExamService examService)
{
      [HttpGet("Gets-Exams")]
    public async Task<List<Exam>> GetExams()
    {
        return await examService.GetExams();
    }

    [HttpPost("Add-Exam")]

    public async Task AddExam(Exam exam)
    {
        await examService.AddExam(exam);
    }

    [HttpDelete("Delete-Exam")]

    public async Task DeleteExam(int examId)
    {
        await examService.DeleteExam(examId);
    }

    [HttpPut("Update-Exam")]

    public async Task UpdateExam(Exam exam)
    {
        await examService.UpdateExam(exam);
    }
}
