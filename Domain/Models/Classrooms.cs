namespace Domain.Models;

public class Classrooms
{
    public int ClassroomId { get; set; }
    public int Year { get; set; }

    public int GradeId { get; set; }

    public string? Section { get; set; }

    public bool Status { get; set; }
    public string? Remarks { get; set; }

    public int TeacherId { get; set; }
}
