using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class LeitorController : ControllerBase
{
    private readonly DataContext context;

    public LeitorController(DataContext Context)
    {
        context = Context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Leitores>>> Get()
    {
        try
        {
            return Ok(await context.Leitor.ToListAsync());
        }
        catch
        {
            return BadRequest("Erro ao obter os Leitores cadastrados.");
        }
    }

    [HttpPost]
    public ActionResult Post(Leitores item)
    {
        return Ok("Apenas validando os dados");
    }

}