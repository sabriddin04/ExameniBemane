namespace Domain.Models;

public class Attendance
{
    public int AttedanceID { get; set; }

    public DateTime Date { get; set; }

    public int StudentId { get; set; }

    public bool Status { get; set; }

    public string? Remark { get; set; }
}
/*

create table Attedance
(
	AttedanceID serial primary key,
	Date date,
	StudentId int references Students(StudentId),
	status bool,
	remark text
)




*/