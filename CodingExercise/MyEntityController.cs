using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodingExercise;

[ApiController]
[Route("[controller]")]
public class MyEntityController : ControllerBase
{
    private CodingExerciseContext _context { get; }

    public MyEntityController(CodingExerciseContext context)
    {
        var options = new DbContextOptionsBuilder<CodingExerciseContext>();
        options.UseInMemoryDatabase("CodingExercise");
       
        _context = new CodingExerciseContext(options.Options);
    }

    [HttpPost]
    public IActionResult MyMethod(
        string? id,
        string? name,
        string? firstName)
    {
        var tm = _context.MyEntity.AddAsync(new MyEntityData { Id = int.Parse(id), name = name }).Result;

        return Ok();
    }

    [HttpGet]
    [Route("{id}")]
    public IActionResult Get(string id)
    {
        return Ok(_context.MyEntity.Where(x => x.Id == int.Parse(id)).FirstOrDefaultAsync().Result);
    }
}