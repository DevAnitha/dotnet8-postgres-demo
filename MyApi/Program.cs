using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Models;

var builder = WebApplication.CreateBuilder(args);

var connStr = builder.Configuration.GetConnectionString("Postgres");

builder.Services.AddDbContext<AppDbContext>(opt =>
    opt.UseNpgsql(connStr));

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/todos", async (AppDbContext db) => await db.Todos.ToListAsync());

app.MapPost("/todos", async (AppDbContext db, Todo todo) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todos/{todo.Id}", todo);
});

app.Run();
