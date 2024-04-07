using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class ParentService(DapperContext context) : IParentService
{


    public async Task<List<Parents>> GetParents()
    {
        var sql = "select * from Parents";
        var result = await context.Connection().QueryAsync<Parents>(sql);
        return result.ToList();
    }


    public async Task AddParent(Parents parent)
    {
        var sql = @"insert into Parents (Email,Password,FirstName,LastName,DateOfBirth,Phone,Mobile,Status)
                   values (@Email,@Password,@FirstName,@LastName,@DateOfBirth,@Phone,@Mobile,@Status)";
        await context.Connection().ExecuteAsync(sql, parent);
    }

    public async Task UpdateParent(Parents parent)
    {
        var sql = @"update Parents set
                      Email=@Email,Password=@Password,FirstName=@FirstName,LastName=@LastName,DateOfBirth=@DateOfBirth,Phone=@Phone,
                      Mobile=@Mobile,Status=@Status
                         where ParentId=@ParentId";

        await context.Connection().ExecuteAsync(sql, parent);
    }

    public async Task DeleteParent(int parentId)
    {
        var sql = "delete from Parents where ParentId=@parentId";

        await context.Connection().ExecuteAsync(sql, new { ParentId = parentId });
    }


}
