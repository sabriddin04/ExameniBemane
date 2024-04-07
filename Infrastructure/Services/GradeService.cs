using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class GradeService(DapperContext context) : IGradeService
{
    public async Task<List<Grade>> GetGrades()
    {
        var sql = "select * from Grade";
        var result = await context.Connection().QueryAsync<Grade>(sql);
        return result.ToList();
    }


    public async Task AddGrade(Grade grade)
    {
        var sql = @"insert into Grade (Name,Description)
                   values (@Name,@Description)";
        await context.Connection().ExecuteAsync(sql, grade);
    }

    public async Task UpdateGrade(Grade grade)
    {
        var sql = @"update Grade set
                      Name=@Name,Description=@Description      
                         where GradeId=@GradeId";

        await context.Connection().ExecuteAsync(sql, grade);
    }

    public async Task DeleteGrade(int gradetId)
    {
        var sql = "delete from Grade where GradeId=@gradeId";

        await context.Connection().ExecuteAsync(sql, new { GradeId = gradetId });
    }

}
