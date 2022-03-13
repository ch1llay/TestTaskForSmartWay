
using BusinessLogicLayer;
using BusinessLogicLayer.Classes;
using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Classes;
using DataAccessLayer.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddTransient<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IDAL, DAL>();


var app = builder.Build();



app.UseAuthorization();

app.MapControllers();

app.Run();
