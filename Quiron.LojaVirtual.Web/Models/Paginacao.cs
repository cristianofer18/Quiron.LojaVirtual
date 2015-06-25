using System;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        public Int32 ItensTotal { get; set; }
        public Int32 ItensPorPagina { get; set; }
        public Int32 PaginaAtual { get; set; }
        public Int32 PaginaTotal { get { return (Int32)Math.Ceiling((decimal)ItensTotal/ItensPorPagina); } }
    }
}