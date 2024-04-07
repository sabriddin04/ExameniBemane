using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassromService(DapperContext context):IClassroomService
{
   
    public async Task<List<Classrooms>> GetClassrooms()
    {
        var sql = "select * from Classrooms";
        var result = await context.Connection().QueryAsync<Classrooms>(sql);
        return result.ToList();
    }


    public async Task AddClassroom(Classrooms classroom)
    {
        var sql = @"insert into Classrooms (Year,GradeId,Section,Status,Remarks,TeacherId)
                   values (@Year,@GradeId,@Section,@Status,@Remarks,@TeacherId)";
        await context.Connection().ExecuteAsync(sql, classroom);
    }

    public async Task UpdateClassroom(Classrooms classroom)
    {
        var sql = @"update Classrooms set
                      Year=@Year,GradeId=@GradeId,Section=@Section,Status=@Status, Remarks=@Remarks,TeacherId=@TeacherId   
                         where ClassroomId=@ClassroomId";

        await context.Connection().ExecuteAsync(sql, classroom);
    }

    public async Task DeleteClassroom(int classroomId)
    {
        var sql = "delete from Grade where ClassroomId=@classroomId";

        await context.Connection().ExecuteAsync(sql, new { ClassroomId = classroomId });
    }
}
