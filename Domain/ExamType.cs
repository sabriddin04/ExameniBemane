namespace Domain;

public class ExamType
{
    public int ExamTypeId { get; set; }
    public string? Name { get; set; }

    public string? Description { get; set; }
}








/*

 create table ExamType
 (
   ExamTypeId  serial primary key,
   Name varchar(45),
   Description text
 )

*/