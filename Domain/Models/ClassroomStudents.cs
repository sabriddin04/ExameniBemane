namespace Domain.Models;

public class ClassroomStudents
{
    public int ClassroomStudentId { get; set; }
    public int ClassroomId { get; set; }
    public int StudentId { get; set; }
}



/*

create table ClassroomStudent
(
  ClassroomStudentId serial primary key,
  ClassroomId int references Classrooms(ClassroomId),
  StudentId int references Students(StudentId),
  unique(ClassroomId,StudentId)	
)

*/