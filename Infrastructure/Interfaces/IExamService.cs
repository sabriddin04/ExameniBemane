using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IExamService
{
    Task<List<Exam>> GetExams();
    Task AddExam(Exam exam);
    Task UpdateExam(Exam exam);
    Task DeleteExam(int examId);
}
