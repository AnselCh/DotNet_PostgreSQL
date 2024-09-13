using Microsoft.EntityFrameworkCore;
using Postgresql_API.Data; // 引用 DbContext 的命名空間

var builder = WebApplication.CreateBuilder(args);

// 從 appsettings.json 中讀取連接字串
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// 配置 DbContext 使用 PostgreSQL
builder.Services.AddDbContext<MyDbContext>(options =>
    options.UseNpgsql(connectionString));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// 開發環境啟用 Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
