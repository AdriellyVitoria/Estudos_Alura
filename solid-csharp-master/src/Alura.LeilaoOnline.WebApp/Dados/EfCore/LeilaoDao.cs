using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Models;




namespace Alura.LeilaoOnline.WebApp.Dados.EfCore
{
    public class LeilaoDao : I_LeilaoDao
    {

        AppDbContext _context;

        public LeilaoDao()
        {
            _context = new AppDbContext();
        }
        public IEnumerable<Categoria> BuscarCategorias()
        {
            return _context.Categorias.ToList();
        }

        public IEnumerable<Leilao> BuscarLeiloes()
        {
            return _context.Leiloes.
                Include(1 => 1.Categoria)
                .ToList();
        }

        public Leilao BuscarPorId(int id)
        {
            return _context.Leiloes.First(1 => 1.Id == id);
        }

        public void Incluir(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();

        }

        public void Alterar(Leilao leilao)
        {
            _context.Leiloes.Add(leilao);
            _context.SaveChanges();
        }

        public void Excluir(Leilao leilao)
        {
            _context.Leiloes.Remove(leilao);
            _context.SaveChanges();
        }

    }
}
