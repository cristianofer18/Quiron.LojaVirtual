using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using Quiron.LojaVirtual.Web.Models;
using Quiron.LojaVirtual.Web.HtmlHelpers;

namespace Quiron.LojaVirtual.Test
{
    [TestClass]
    public class UnitTestQuiron
    {
        //[TestMethod]
        //public void Take()
        //{
        //    int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //    var resultado = from n in numeros.Take(5) select n;

        //    int[] teste = { 5, 4, 1, 3, 8 };

        //    CollectionAssert.AreEqual(resultado.ToArray(), teste);
        //}

        //[TestMethod]
        //public void Skip()
        //{
        //    int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //    var resultado = from n in numeros.Take(5).Skip(2) select n;

        //    int[] teste = { 1, 3, 9 };

        //    CollectionAssert.AreEqual(resultado.ToArray(), teste);
        //}

        [TestMethod]
        public void TestarSePaginacaoEstaSendoGeradoCorretamente()
        {
            //Install-Package Microsoft.AspNet.Mvc

            // Arrange -- prepara variáveis que serão utilizadas
            HtmlHelper html = null;

            var paginacao = new Paginacao { ItensTotal = 28, PaginaAtual = 2, ItensPorPagina = 10 };

            Func<int, string> paginaUrl = i => "Pagina" + i;

            // Act
            MvcHtmlString resultado = html.PageLinks(paginacao, paginaUrl);            

            // Assert
            Assert.AreEqual(                
                @"<a class=""btn btn-default"" href=""Pagina1"">1</a>"
                + @"<a class=""btn btn-default btn-primary selected"" href=""Pagina2"">2</a>"
                + @"<a class=""btn btn-default"" href=""Pagina3"">3</a>", resultado.ToString());
        }
    }
}
