using Quiron.LojaVirtual.Dominio.Entidade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Repositorio
{
    public class ProdutosRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        //public IEnumerable<Produto> GetProdutos()
        //{
        //    return from produtos in _context.Produtos select produtos;
        //}

        public IEnumerable<Produto> GetProdutos
        {
            get { return _context.Produtos; }
        }

    }
}
