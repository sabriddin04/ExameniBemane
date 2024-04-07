using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ClassroomStudentService(DapperContext context) : IClassroomStudentService
{
    public async Task<List<ClassroomStudents>> GetClassroomStudents()
    {
        var sql = "select * from ClassroomStudents ";
        var result = await context.Connection().QueryAsync<ClassroomStudents>(sql);
        return result.ToList();
    }


    public async Task AddClassroomStudent(ClassroomStudents classroom)
    {
        var sql = @"insert into ClassroomStudents (ClassroomId,StudentId)
                   values (@ClassroomId,@StudentId)";
        await context.Connection().ExecuteAsync(sql, classroom);
    }

    public async Task UpdateClassroomStudent(ClassroomStudents classroom)
    {
        var sql = @"update Classrooms set
                      ClassroomId=@ClassroomId,StudentId=@StudentId
                         where ClassroomStudentId=@ClassroomStudentId";
        await context.Connection().ExecuteAsync(sql, classroom);
    }

    public async Task DeleteClassroomStudent(int classroomStudentId)
    {
        var sql = "delete from Classrooms where ClassroomStudentId=@classroomId";

        await context.Connection().ExecuteAsync(sql, new { ClassroomStudentId = classroomStudentId });
    }
}
