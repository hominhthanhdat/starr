using Star.Converters;
using Star.Models;
using Microsoft.EntityFrameworkCore;
using Star.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<AccountService, AccountServiceImplement>();
builder.Services.AddScoped<DepartmentService, DepartmentServiceImplement>();
builder.Services.AddScoped<EmployeeService, EmployeeServiceImplement>();
builder.Services.AddScoped<ContractService, ContractServiceImplement>();
builder.Services.AddCors();
builder.Services.AddControllers().AddJsonOptions(option =>
{
    option.JsonSerializerOptions.Converters.Add(new DateConvert());
});
builder.Services.AddDbContext<DatabaseContext>(options => options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration["ConnectionStrings:DefaultConnection"]));
builder.Services.AddControllers();
var app = builder.Build();
app.UseCors(builder => builder
                .AllowAnyHeader()
                .AllowAnyMethod()
                .SetIsOriginAllowed((host) => true)
                .AllowCredentials()
            );
app.MapControllers();
app.Run();
