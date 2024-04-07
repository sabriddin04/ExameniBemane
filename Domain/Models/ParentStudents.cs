namespace Domain.Models;

public class ParentStudents
{
    public Parents Parent { get; set; }

    public List<Students> Students { get; set; }
}
