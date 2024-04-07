namespace Domain.Models;

public class StudentAtendances
{
    public Students Student { get; set; }

    public List<Attendance> Attendances { get; set; }
}
