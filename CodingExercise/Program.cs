using CodingExercise;
using Microsoft.EntityFrameworkCore;

const string dbName = "CodingExerciseDB";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<CodingExerciseContext>(opt =>
    opt.UseInMemoryDatabase(dbName));

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();