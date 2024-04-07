using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IGradeService
{
    Task<List<Grade>> GetGrades();
    Task AddGrade(Grade grade);
    Task UpdateGrade(Grade grade);
    Task DeleteGrade(int gradeId);
}
