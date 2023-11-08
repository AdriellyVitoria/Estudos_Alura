using AutoMapper;
using MemotecaApi.Data;
using MemotecaApi.Dtos;
using MemotecaApi.Models;

namespace MemotecaApi.Services;

public class PensamentoService : IPensamentoService
{
    private readonly AppDbContext context;
    private readonly IMapper mapper;

    public PensamentoService(AppDbContext context, IMapper mapper)
    {
        this.context=context;
        this.mapper=mapper;
    }

    public IList<ReadPensamentoDto> BuscaTodos(int _page, int _limit) // Paginação
    {
        int pularPagina = _limit * (_page - 1);
        List<Pensamento> pensamentos = context.Pensamentos
            .Skip(pularPagina)
            .Take(_limit)
            .ToList();
        return mapper.Map<List<ReadPensamentoDto>>(pensamentos);
    }

    public ReadPensamentoDto CriarPensamento(CreatePensamentoDto dto)
    {
        Pensamento pensamento = mapper.Map<Pensamento>(dto);
        context.Pensamentos.Add(pensamento);
        context.SaveChanges(); //salva mudanças no banco
        return mapper.Map<ReadPensamentoDto>(pensamento);
    }

    public void ApagarPensamento(Guid id)
    {
        Pensamento pensamento = context.Pensamentos.FirstOrDefault(p => p.Id == id)!; //Para buscar o pensamento
        context.Remove(pensamento);
        context.SaveChanges();
    }

    public ReadPensamentoDto BuscarOne(Guid id)
    {
        Pensamento pensamento = context.Pensamentos.FirstOrDefault(p => p.Id == id)!;
        return mapper.Map<ReadPensamentoDto>(pensamento);
    }

    public ReadPensamentoDto Editar(UpdatePensamentoDto readDto)
    {
        Pensamento pensamento = mapper.Map<Pensamento>(readDto);
        context.Pensamentos.Update(pensamento);
        context.SaveChanges();
        return mapper.Map<ReadPensamentoDto>(pensamento);
    }
}
