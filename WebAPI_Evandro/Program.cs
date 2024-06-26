﻿using Microsoft.EntityFrameworkCore;
using WebAPI_Evandro.DataContext;
using WebAPI_Evandro.Service.FuncionarioService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFuncionarioInterface,FuncionarioService>();
builder.Services.AddDbContext<AplicationDBContext>(options =>
{
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaltConnection"));
});

#region [Cors]
builder.Services.AddCors();
#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI();
}

#region [Cors]
app.UseCors(c =>
{
  c.AllowAnyHeader();
  c.AllowAnyMethod();
  c.AllowAnyOrigin();

});
#endregion

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
