using Dapper;
using Domain;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ExamTypeService(DapperContext context):IExamTypeService
{
       public async Task<List<ExamType>> GetExamTypes()
    {
        var sql = "select * from ExamType";
        var result = await context.Connection().QueryAsync<ExamType>(sql);
        return result.ToList();
    }


    public async Task AddExamType(ExamType examType)
    {
        var sql = @"insert into ExamType (Name,Description)
                   values (@Name,@Description)";
        await context.Connection().ExecuteAsync(sql, examType);
    }

    public async Task UpdateExamType(ExamType examType)
    {
        var sql = @"update ExamType set
                      Name=@Name,Description=@Description      
                         where ExamTypeId=@ExamTypeId";

        await context.Connection().ExecuteAsync(sql, examType);
    }

    public async Task DeleteExamType(int examTypeId)
    {
        var sql = "delete from Grade where ExamTypeId=@examTypeId";

        await context.Connection().ExecuteAsync(sql, new { GradeId = examTypeId });
    }
}
