using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ExamResultService(DapperContext context):IExamResultService
{
public async Task<List<ExamResult>> GetExamResults()
    {
        var sql = "select * from ExamResult";
        var result = await context.Connection().QueryAsync<ExamResult>(sql);
        return result.ToList();
    }


    public async Task AddExamResult(ExamResult examResult)
    {
        var sql = @"insert into ExamResult (ExamId,StudentId,CourseId,Marks)
                   values (@ExamId,@StudentId,@CourseId,@Marks)";
        await context.Connection().ExecuteAsync(sql, examResult);
    }

    public async Task UpdateExamResult(ExamResult examResult)
    {
        var sql = @"update ExamResult set
                      ExamId=@ExamId,StudentId=@StudentId,CourseId=@CourseId,Marks=@Marks    
                         where ExamResultId=@ExamResultId";

        await context.Connection().ExecuteAsync(sql, examResult);
    }

    public async Task DeleteExamResult(int examResultId)
    {
        var sql = "delete from ExamResult where ExamtId=@examtId";

        await context.Connection().ExecuteAsync(sql, new { ExamResultId = examResultId });
    }
}
