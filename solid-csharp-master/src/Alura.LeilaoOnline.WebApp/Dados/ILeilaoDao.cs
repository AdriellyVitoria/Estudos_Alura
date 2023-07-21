using Alura.LeilaoOnline.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Alura.LeilaoOnline.WebApp.Models;


namespace Alura.LeilaoOnline.WebApp.Dados
{
    public interface I_LeilaoDao
    {
        IEnumerable<Categoria> BuscarCategorias();
        IEnumerable<Leilao> BuscarLeiloes();
        Leilao BuscarPorId(int id);
        void Incluir(Leilao leilao);
        void Alterar(Leilao leilao);
        void Excluir(Leilao leilao);
    }
}
