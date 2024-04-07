using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class CourseService(DapperContext context):ICourseService
{
    
    public async Task<List<Courses>> GetCourses()
    {
        var sql = "select * from Courses";
        var result = await context.Connection().QueryAsync<Courses>(sql);
        return result.ToList();
    }


    public async Task AddCourse(Courses course)
    {
        var sql = @"insert into Courses (Name,Description,GradeId)
                   values (@Name,@Description,@GradeId)";
        await context.Connection().ExecuteAsync(sql, course);
    }

    public async Task UpdateCourse(Courses course)
    {
        var sql = @"update Courses set
                      Name=@Name,Description=@Description,GradeId=@GradeId      
                         where CourseId=@CourseId";

        await context.Connection().ExecuteAsync(sql, course);
    }

    public async Task DeleteCourse(int courseId)
    {
        var sql = "delete from Courses where CourseId=@courseId";

        await context.Connection().ExecuteAsync(sql, new { CourseId = courseId });
    }
}
