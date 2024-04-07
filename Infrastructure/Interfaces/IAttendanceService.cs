using Domain.Models;

namespace Infrastructure.Interfaces;

public interface IAttendanceService
{
    
    Task<List<Attendance>> GetAttendances();
    Task AddAttendance(Attendance attendance);
    Task UpdateAttendance(Attendance attendance);
    Task DeleteAttendance(int attendanceId);
}
