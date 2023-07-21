using Alura.LeilaoOnline.WebApp.Models;
using System.Collections;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IProdutosServices
    {

        IEnumerable<Leilao> PesquisaLeiloesEmPregaoPorTermo(string termo);
        IEnumerable<CategoriaComInfoLeilao> 
            ConsultaCategoriasComTotalDeLeiloesEmPregao();

        Categoria ConsultaCategoriaPorIdComLeiloesEmPregao(int id);
    }

}



