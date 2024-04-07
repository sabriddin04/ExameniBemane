using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IExamResultService
{
    Task<List<ExamResult>> GetExamResults();
    Task AddExamResult(ExamResult examResult);
    Task UpdateExamResult(ExamResult examResult);
    Task DeleteExamResult(int examResultId);
}
