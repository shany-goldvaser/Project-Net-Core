using projectErov.Core.Entities;
using projectErov.Core.IRepository;
using projectErov.Core.IService;
using projectErov.Data.Repository;
using projectErov.Data;
using projectErov.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<DataContext>(option =>
{
	option.UseSqlServer("Data Source = DESKTOP-Shany; Initial Catalog = ErovProject; Integrated Security = true; ");

});
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
