using System.Collections;
using Alura.LeilaoOnline.WebApp.Models;
using System.Collections.Generic;

namespace Alura.LeilaoOnline.WebApp.Services
{
    public interface IAdminServices
    {
        IEnumerable<Categoria> ConsultaCategorias();
        IEnumerable<Leilao> ConsultaLeilao();
        Leilao ConsultaLeilaoPorId(int id);
        void CadastraLeilao(Leilao leilao);
        void ModificarLeilao(Leilao leilao);
        void RemoveLeilao(Leilao leilao);
        void IniciaPregaDoLeilaoComId(int id);
        void FinalizaPregaoDoLeilaoComId(int id);
    }
}
