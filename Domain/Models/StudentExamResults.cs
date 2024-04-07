namespace Domain.Models;

public class StudentExamResults
{
    public Students Student { get; set; }

    public List<ExamResult> ExamResults { get; set; }
}
