using Domain;

namespace Infrastructure.Interfaces;

public interface IExamTypeService
{
    Task<List<ExamType>> GetExamTypes();
    Task AddExamType(ExamType examType);
    Task UpdateExamType(ExamType examType);
    Task DeleteExamType(int examTypeId);
}
