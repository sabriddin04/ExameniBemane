using Domain.Models;

using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
[Controller]
[Route("[controller]")]
public class AttendanceController(IAttendanceService attendanceService)
{
        [HttpGet("Gets-Courses")]
    public async Task<List<Attendance>> GetAttendances()
    {
        return await attendanceService.GetAttendances();
    }

    [HttpPost("Add-Attendance")]

    public async Task AddAttendance(Attendance attendance)
    {
        await attendanceService.AddAttendance(attendance);
    }

    [HttpDelete("Delete-Attendance")]

    public async Task DeleteParent(int attendanceId)
    {
        await attendanceService.DeleteAttendance(attendanceId);
    }

    [HttpPut("Update-Attendance")]

    public async Task UpdateParent(Attendance attendance)
    {
        await attendanceService.UpdateAttendance(attendance);
    }

}
