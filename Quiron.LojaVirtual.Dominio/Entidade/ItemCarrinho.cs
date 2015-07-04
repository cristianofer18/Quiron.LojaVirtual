using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
    public class ItemCarrinho
    {
        public Produto Produto { get; set; }

        public int Quantidade { get; set; }
    }
}
