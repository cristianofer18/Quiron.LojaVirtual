using Quiron.LojaVirtual.Dominio.Repositorio;
using Quiron.LojaVirtual.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        private int ProdutosPorPagina = 8;
        //
        // GET: /Vitrine/
        public ViewResult ListaProdutos(string categoria, int pagina = 1)
        {
            _repositorio = new ProdutosRepositorio();

            var viewModel = new ProdutosViewModel
            {
                Produtos = _repositorio.GetProdutos.OrderBy(p => p.Descricao)
                .Where(p => p.Categoria == null || p.Categoria == categoria)
                .Skip((pagina - 1) * ProdutosPorPagina).Take(ProdutosPorPagina),
                Paginacao = new Paginacao
                {
                    PaginaAtual = pagina,
                    ItensPorPagina = ProdutosPorPagina,
                    ItensTotal = _repositorio.GetProdutos.Count()
                },
                CategoriaAtual = categoria
            };

            return View(viewModel);
        }
    }
}