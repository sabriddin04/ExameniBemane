using Dapper;
using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;

namespace Infrastructure.Services;

public class StudentService(DapperContext context, StudentAtendances studentAtendances, StudentExamResults studentExamResults,ParentStudents parentStudents) : IStudentService
{

    public async Task<List<Students>> GetStudents()
    {
        var sql = "select * from Students";
        var result = await context.Connection().QueryAsync<Students>(sql);
        return result.ToList();
    }


    public async Task AddStudent(Students student)
    {
        var sql = @"insert into Students (Email,Password,FirstName,LastName,DateOfBirth,Phone,Mobile,ParentId,DateOfJoin,Status)
                   values (@Email,@Password,@FirstName,@LastName,@DateOfBirth,@Phone,@Mobile,@ParentId,@DateOfJoin,@Status)";
        await context.Connection().ExecuteAsync(sql, student);
    }

    public async Task UpdateStudent(Students student)
    {
        var sql = @"update Students set
                      Email=@Email,Password=@Password,FirstName=@FirstName,LastName=@LastName,DateOfBirth=@DateOfBirth,Phone=@Phone,
                      Mobile=@Mobile,ParentId=@ParentId,DateOfJoin=@DateOfJoin,Status=@Status
                         where StudentId=@StudentId";

        await context.Connection().ExecuteAsync(sql, student);
    }

    public async Task DeleteStudent(int studentId)
    {
        var sql = "delete from Students where StudentId=@studentId";

        await context.Connection().ExecuteAsync(sql, new { StudentId = studentId });
    }


    public async Task<StudentAtendances> GetStudentAtendances(int studentId)
    {
        try
        {
            var sql = @"select * from Students where StudentId=@studentId;
                  select * from Attendance where StudentId=@StudentId";



            using (var multiple = await context.Connection().QueryMultipleAsync(sql, new { StudentId = studentId }))
            {
                studentAtendances.Student = await multiple.ReadFirstAsync<Students>();
                var list = await multiple.ReadAsync<Attendance>();
                studentAtendances.Attendances = list.ToList();
            }
            return studentAtendances;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }

    public async Task<StudentExamResults> GetStudentExamResults(int studentId)
    {
        try
        {
            var sql = @"select * from Students where StudentId=@studentId;
                  select * from ExamResult where StudentId=@StudentId";



            using (var multiple = await context.Connection().QueryMultipleAsync(sql, new { StudentId = studentId }))
            {
                studentExamResults.Student = await multiple.ReadFirstAsync<Students>();
                var list = await multiple.ReadAsync<ExamResult>();
                studentExamResults.ExamResults = list.ToList();
            }
            return studentExamResults;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }
    public async Task<ParentStudents> GetParentWithStudents(int parentId)
    {
        try
        {
            var sql = @"select * from Parents where ParentId=@ParentId;
                  select * from Students where ParentId=@ParentId";

            using (var multiple = await context.Connection().QueryMultipleAsync(sql, new { ParentId = parentId }))
            {
                parentStudents.Parent = await multiple.ReadFirstAsync<Parents>();
                var list = await multiple.ReadAsync<Students>();
                parentStudents.Students = list.ToList();
            }
            return parentStudents;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return null;
        }
    }











}
