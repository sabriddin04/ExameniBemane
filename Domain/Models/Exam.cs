namespace Domain.Models;

public class Exam
{
    public int ExamId { get; set; }

    public int ExamTypeId { get; set; }

    public string? Name { get; set; }

    public DateTime StartDate { get; set; }

}


/*

 create table Exam
 (
   ExamId serial primary key,
   ExamTypeId int references ExamType(ExamTypeId),
   Name varchar(45),
   StartDate date
 )



*/