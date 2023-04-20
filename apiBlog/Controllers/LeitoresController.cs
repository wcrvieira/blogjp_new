using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class LeitoresController : ControllerBase
{
    private readonly DataContext context;

    public LeitoresController(DataContext Context)
    {
        context = Context;
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] Leitores model)
    {
        try
        {
            context.Leitor.Add(model);
            await context.SaveChangesAsync();
            return Ok("Leitor salvo com sucesso.");
        }
        catch
        {
            return BadRequest("Falha ao inserir o Leitor.");
        }
    }

    [HttpGet]
    public ActionResult<IEnumerable<Leitores>> Get()
    {
        try
        {
            return Ok(context.Leitor.ToList());
        }
        catch
        {
            return BadRequest("Erro ao obter os Leitores.");
        }
    }


}
