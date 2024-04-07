namespace Domain.Models;

public class ExamResult
{
    public int ExamResultId { get; set; }

    public int ExamId { get; set; }

    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public string? Marks { get; set; }
}


/*

 create table ExamResult
 (   
	 ExamResultId serial primary key,
	 ExamId int references Exam(ExamId),
	 StudentId int references Students(StudentId),
	 CourseId int references Courses(CourseId),
	 Marks varchar(45) 
 )



*/