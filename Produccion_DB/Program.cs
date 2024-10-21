using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Produccion_DB.Models;

var builder = WebApplication.CreateBuilder(args);

Env.Load();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about  configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//var username = Env.GetString("USERNAME");
//var password = Env.GetString("PASSWORD");

// Reemplazar las variables en la cadena de conexión
//var connectionString = builder.Configuration.GetConnectionString("CadenaSqlServer")!
//    .Replace("${USERNAME}", username)
//    .Replace("${PASSWORD}", password);

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSqlServer"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("NewPolicy", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("NewPolicy");

app.Run();