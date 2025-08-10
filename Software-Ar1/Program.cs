using System;
using Microsoft.EntityFrameworkCore;

using Software_Ar.Infrastructure.Persistence;
using Software_Ar.Infrastructure.Persistence.Repositories;
using Software_Ar.Core.Domain.Shared;




var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<AppDbContext> (options =>
      options.UseSqlServer(builder.Configuration.GetConnectionString("Soft")));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>)); ;

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
