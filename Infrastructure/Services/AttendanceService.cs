using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class AttendanceService(DapperContext context):IAttendanceService
{
        public async Task<List<Attendance>> GetAttendances()
    {
        var sql = "select * from Attendance";
        var result = await context.Connection().QueryAsync<Attendance>(sql);
        return result.ToList();
    }


    public async Task AddAttendance(Attendance attendance)
    {
        var sql = @"insert into Attendance (Date,StudentId,Status,Remark)
                   values (@Date,@StudentId,@Status,@Remark)";
        await context.Connection().ExecuteAsync(sql, attendance);
    }

    public async Task UpdateAttendance(Attendance attendance)
    {
        var sql = @"update Attendance set
                      Date=@Date,StudentId=@StudentId,Status=@Status,Remark=@Remark
                         where AttedanceID=@AttedanceID";

        await context.Connection().ExecuteAsync(sql, attendance);
    }

    public async Task DeleteAttendance(int attedanceID)
    {
        var sql = "delete from Attendance where AttedanceID=@attedanceID";

        await context.Connection().ExecuteAsync(sql, new { AttedanceID = attedanceID });
    }
}
