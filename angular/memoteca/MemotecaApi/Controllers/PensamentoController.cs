using AutoMapper;
using MemotecaApi.Data;
using MemotecaApi.Dtos;
using MemotecaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MemotecaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PensamentoController : ControllerBase
{
    private readonly AppDbContext context;
    private readonly IMapper mapper;

    public PensamentoController(AppDbContext context, IMapper mapper)
    {
        this.context=context;
        this.mapper=mapper;
    }

    [HttpGet]
    public IActionResult Get()
    {
        IList<ReadPensamentoDto> dtos = mapper.Map<List<ReadPensamentoDto>>(context.Pensamentos.ToList());
        return Ok(dtos);
    }

    [HttpPost]
    public IActionResult Post(CreatePensamentoDto dto)
    {
        Pensamento pensamento = mapper.Map<Pensamento>(dto);
        context.Pensamentos.Add(pensamento);
        context.SaveChanges(); //salva mudanças no banco
        ReadPensamentoDto readDto = mapper.Map<ReadPensamentoDto>(pensamento);
        return Ok(readDto);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        Pensamento pensamento = context.Pensamentos.FirstOrDefault(p => p.Id == id)!; //Para buscar o pensamento
        context.Remove(pensamento);
        context.SaveChanges();
        return NoContent();
    }

    [HttpGet("{id}")]
    public IActionResult GetOne(Guid id)
    {
        Pensamento pensamento = context.Pensamentos.FirstOrDefault(p => p.Id == id)!;
        ReadPensamentoDto readDto = mapper.Map<ReadPensamentoDto>(pensamento);
        return Ok(readDto);
    }
}