using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ExamService(DapperContext context):IExamService
{

 public async Task<List<Exam>> GetExams()
    {
        var sql = "select * from Exam";
        var result = await context.Connection().QueryAsync<Exam>(sql);
        return result.ToList();
    }


    public async Task AddExam(Exam exam)
    {
        var sql = @"insert into Exam (ExamTypeId,Name,StartDate)
                   values (@ExamTypeId,@Name,@StartDate)";
        await context.Connection().ExecuteAsync(sql, exam);
    }

    public async Task UpdateExam(Exam exam)
    {
        var sql = @"update Exam set
                      ExamTypeId=@ExamTypeId,Name=@Name,StartDate=@StartDate    
                         where ExamId=@ExamId";

        await context.Connection().ExecuteAsync(sql, exam);
    }

    public async Task DeleteExam(int examtId)
    {
        var sql = "delete from Exam where ExamtId=@examtId";

        await context.Connection().ExecuteAsync(sql, new { ExamtId = examtId });
    }

}
