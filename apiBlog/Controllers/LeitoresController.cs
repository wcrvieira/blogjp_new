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
    public ActionResult Post(Leitores model)
    {
        try
        {
            context.Leitor.Add(model);
            context.SaveChanges();
            return Ok("Tipo de curso salvo com sucesso");
        }
        catch
        {
            return BadRequest("Falha ao inserir o tipo de curso informado");
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
            return BadRequest("Erro ao obter os tipos de curso");
        }
    }


}
