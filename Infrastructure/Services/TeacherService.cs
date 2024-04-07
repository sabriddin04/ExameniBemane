using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class TeacherService(DapperContext context):ITeacherService
{
        public async Task<List<Teachers>> GetTeachers()
    {
        var sql = "select * from Teachers";
        var result = await context.Connection().QueryAsync<Teachers>(sql);
        return result.ToList();
    }


    public async Task AddTeacher( Teachers teacher)
    {
        var sql = @"insert into Teachers (Email,Password,FirstName,LastName,DateOfBirth,Phone,Mobile,Status)
                   values (@Email,@Password,@FirstName,@LastName,@DateOfBirth,@Phone,@Mobile,@Status)";
        await context.Connection().ExecuteAsync(sql, teacher);
    }

    public async Task UpdateTeacher(Teachers teacher)
    {
        var sql = @"update Teachers set
                      Email=@Email,Password=@Password,FirstName=@FirstName,LastName=@LastName,DateOfBirth=@DateOfBirth,Phone=@Phone,
                      Mobile=@Mobile,Status=@Status
                         where TeacherId=@TeacherId";

        await context.Connection().ExecuteAsync(sql, teacher);
    }

    public async Task DeleteTeacher(int teacherId)
    {
        var sql = "delete from Teachers where TeacherId=@teacherId";

        await context.Connection().ExecuteAsync(sql, new { TeacherId = teacherId });
    }
    
}
