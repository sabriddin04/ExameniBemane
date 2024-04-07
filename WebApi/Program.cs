using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Infrastructure.Services;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 builder.Services.AddScoped<IAttendanceService, AttendanceService>();
 builder.Services.AddScoped<IClassroomService, ClassromService>();
 builder.Services.AddScoped<DapperContext>();
 builder.Services.AddScoped<IClassroomStudentService,ClassroomStudentService>();
 builder.Services.AddScoped<IExamResultService,ExamResultService>();
 builder.Services.AddScoped<IExamService,ExamService>();
 builder.Services.AddScoped<IExamTypeService,ExamTypeService>();
 builder.Services.AddScoped<ICourseService,CourseService>();
 builder.Services.AddScoped<IGradeService,GradeService>();
 builder.Services.AddScoped<IStudentService,StudentService>();
 builder.Services.AddScoped<IParentService,ParentService>();
 builder.Services.AddScoped<ITeacherService,TeacherService>();
 builder.Services.AddSingleton<StudentAtendances>();
 builder.Services.AddSingleton<StudentExamResults>();
 builder.Services.AddSingleton<ParentStudents>();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.MapControllers();
app.Run();

