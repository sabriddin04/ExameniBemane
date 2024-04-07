namespace Domain.Models;

public class Grade
{
    public int GradeId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

}
// GradeId serial primary key,
// 	Name varchar(45),
// 	Description text