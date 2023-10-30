using MemotecaApi.Dtos;
using MemotecaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace MemotecaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PensamentoController : ControllerBase
{
    private readonly IPensamentoService service;

    public PensamentoController(IPensamentoService service)
    {
        this.service=service;
    }

    [HttpGet]
    public IActionResult Get() //faz a requisição
    {
        try
        {
            IList<ReadPensamentoDto> dtos = service.BuscaTodos(); //Chama o servico
            return Ok(dtos); //retorna o servico
        }
        catch (Exception)
        {
            return StatusCode(500); //culpa do servidor
        }
    }

    [HttpPost]
    public IActionResult Post(CreatePensamentoDto dto)
    {
        try
        {
            ReadPensamentoDto readDto = service.CriarPensamento(dto);
            return Ok(readDto);
        }
        catch (Exception)
        {
            return BadRequest(); //Culpa do cliente
        }
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        try
        {
            service.ApagarPensamento(id);
            return NoContent();
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(Guid id)
    {
        try
        {
            ReadPensamentoDto readDto = service.BuscarOne(id);
            if (readDto != null) return Ok(readDto);
        }
        catch (Exception)
        {
            return BadRequest();
        }
        
        return NotFound();
    }

    [HttpPut]
    public IActionResult Put(UpdatePensamentoDto readDto)
    {
        try
        {
            ReadPensamentoDto pensamento = service.Editar(readDto);
            return Ok(pensamento);
        }
        catch (Exception)
        {
            return BadRequest();
        }
    }
}