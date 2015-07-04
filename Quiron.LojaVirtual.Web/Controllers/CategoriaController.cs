using Quiron.LojaVirtual.Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Quiron.LojaVirtual.Web.Controllers
{
    public class CategoriaController : Controller
    {
        private ProdutosRepositorio _repositorio;
        //
        // GET: /Categoria/
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Menu(string categoria = null)
        {
            _repositorio = new ProdutosRepositorio();

            ViewBag.CategoriaSelecionada = categoria;

            IEnumerable<string> categorias = _repositorio.GetProdutos.Select(p => p.Categoria).Distinct();
            
            return PartialView(categorias);
        }
	}
}