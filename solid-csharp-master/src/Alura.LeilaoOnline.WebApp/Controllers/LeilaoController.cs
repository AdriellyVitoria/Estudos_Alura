
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Alura.LeilaoOnline.WebApp.Models;

using Alura.LeilaoOnline.WebApp.Dados;

namespace Alura.LeilaoOnline.WebApp.Controllers
{
    public class LeilaoController : Controller
    {
        I_LeilaoDao _dao;
        public LeilaoController(I_LeilaoDao dao)
        {
            _dao = dao;
        }

        public IActionResult Index()    
        {
            var leiloes = _dao.BuscarLeiloes();
            return View(leiloes);
        } 

        [HttpGet]
        public IActionResult Insert()
        {
            ViewData["Categorias"] = _dao.BuscarCategorias();
            ViewData["Operacao"] = "Inclusão";
            return View("Form");
        }

        [HttpPost]
        public IActionResult Insert(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _dao.Incluir(model);
                return RedirectToAction("Index");
            }
            ViewData["Categorias"] = _dao.BuscarCategorias();
            ViewData["Operacao"] = "Inclusão";
            return View("Form", model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Categorias"] = _dao.BuscarCategorias();
            ViewData["Operacao"] = "Edição";
            var leilao = _dao.BuscarCategorias();
            if (leilao == null) return NotFound();
            return View("Form", leilao);
        }

        [HttpPost]
        public IActionResult Edit(Leilao model)
        {
            if (ModelState.IsValid)
            {
                _dao.Alterar(model);
                return RedirectToAction("Index");
            }
            ViewData["Categorias"] = _dao.BuscarCategorias();
            ViewData["Operacao"] = "Edição";
            return View("Form", model);
        }

        [HttpPost]
        public IActionResult Inicia(int id)
        {
            var leilao = _dao.BuscarCategorias(id);
            if (leilao == null) return NotFound();
            if (leilao.Situacao != SituacaoLeilao.Rascunho) return 
                    StatusCode(405);
            leilao.Situacao = SituacaoLeilao.Pregao;
            leilao.Inicio = DateTime.Now;
            _dao.Alterar(leilao);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Finaliza(int id)
        {
            var leilao = _dao.BuscarCategorias(id);
            if (leilao == null) return NotFound();
            if (leilao.Situacao != SituacaoLeilao.Pregao) return StatusCode(405);
            leilao.Situacao = SituacaoLeilao.Finalizado;
            leilao.Termino = DateTime.Now;
            _dao.Alterar(leilao);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Remove(int id)
        {
            var leilao = _dao.BuscarCategorias(id);
            if (leilao == null) return NotFound();
            if (leilao.Situacao == SituacaoLeilao.Pregao) return StatusCode(405);
            _dao.Excluir(leilao);
            return NoContent();
        }

        [HttpGet]
        public IActionResult Pesquisa(string termo)
        {
            ViewData["termo"] = termo;
            var leiloes = _dao.BuscarCategorias();
                .Where(l => string.IsNullOrWhiteSpace(termo) || 
                    l.Titulo.ToUpper().Contains(termo.ToUpper()) || 
                    l.Descricao.ToUpper().Contains(termo.ToUpper()) ||
                    l.Categoria.Descricao.ToUpper().Contains(termo.ToUpper())
                );
            return View("Index", leiloes);
        }
    }
}
