using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AtvRelacionamento1109.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AtvRelacionamento1109Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AtvRelacionamento1109Context") ?? throw new InvalidOperationException("Connection string 'AtvRelacionamento1109Context' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.Run();
