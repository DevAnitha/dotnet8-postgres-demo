using Microsoft.EntityFrameworkCore;
using MyApi.Data;
using MyApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Get the connection string from appsettings.Development.json
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

// -------------------- TODOS --------------------
app.MapGet("/todos", async (AppDbContext db) =>
    await db.Todos.ToListAsync());

app.MapPost("/todos", async (AppDbContext db, Todo todo) =>
{
    db.Todos.Add(todo);
    await db.SaveChangesAsync();
    return Results.Created($"/todos/{todo.Id}", todo);
});

// -------------------- USERS --------------------
app.MapGet("/users", async (AppDbContext db) =>
    await db.Users.AsNoTracking().ToListAsync());

app.MapGet("/users/{id:int}", async (int id, AppDbContext db) =>
{
    var user = await db.Users.FindAsync(id);
    return user is null ? Results.NotFound() : Results.Ok(user);
});

app.MapPost("/users", async (AppDbContext db, User user) =>
{
    // Reset ID and timestamps
    user.Id = 0;
    user.CreatedUtc = DateTime.UtcNow;
    db.Users.Add(user);
    await db.SaveChangesAsync();
    return Results.Created($"/users/{user.Id}", user);
});

app.MapPut("/users/{id:int}", async (int id, AppDbContext db, User input) =>
{
    var user = await db.Users.FindAsync(id);
    if (user is null)
        return Results.NotFound();

    user.Name = input.Name;
    user.Email = input.Email;
    user.PasswordHash = input.PasswordHash;
    user.UpdatedUtc = DateTime.UtcNow;

    await db.SaveChangesAsync();
    return Results.NoContent();
});

app.MapDelete("/users/{id:int}", async (int id, AppDbContext db) =>
{
    var user = await db.Users.FindAsync(id);
    if (user is null)
        return Results.NotFound();

    db.Users.Remove(user);
    await db.SaveChangesAsync();
    return Results.NoContent();
});

// ------------------------------------------------

app.Run();
