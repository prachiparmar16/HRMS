using FluentValidation;
using FluentValidation.AspNetCore;
using HRMS.Database.Validators;
using HRMS.WebAPI.Data;
using HRMS.WebAPI.Repositories;
using HRMS.WebAPI.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddDbContext<HrmsDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("HrmsCS")));
builder.Services.AddValidatorsFromAssemblyContaining<UserLoginValidator>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentService>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeService>();
builder.Services.AddScoped<ILeaveRepository, LeaveService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
