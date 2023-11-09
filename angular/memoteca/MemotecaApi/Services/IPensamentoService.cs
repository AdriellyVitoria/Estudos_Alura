using MemotecaApi.Dtos;

namespace MemotecaApi.Services;

public interface IPensamentoService
{
    void ApagarPensamento(Guid id);
    ReadPensamentoDto BuscarOne(Guid id);
    IList<ReadPensamentoDto> BuscaTodos(int _page, int _limit, string? q);
    ReadPensamentoDto CriarPensamento(CreatePensamentoDto dto);
    ReadPensamentoDto Editar(UpdatePensamentoDto readDto);
}