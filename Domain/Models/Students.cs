namespace Domain.Models;

public class Students:Person
{
    public int StudentId { get; set; }
    public int ParentId { get; set; }
    public DateOnly DateOfJoin { get; set; }
   

}
