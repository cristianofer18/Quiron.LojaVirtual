using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiron.LojaVirtual.Dominio.Entidade
{
    public class Carrinho
    {
        private readonly List<ItemCarrinho> _itensCarrinho = new List<ItemCarrinho>();

        //Adicionar

        public void AdicionarItem(Produto produto, int quantidade)
        {
            var item = _itensCarrinho.FirstOrDefault(p => p.Produto.ProdutoId == produto.ProdutoId);

            if (item == null)
            {
                _itensCarrinho.Add(new ItemCarrinho { 
                    Produto = produto,
                    Quantidade = quantidade
                });
            }
            else
            {
                item.Quantidade += quantidade;
            }
        }

        //Remover

        public void RemoverItem(Produto produto)
        {
            _itensCarrinho.RemoveAll(p => p.Produto.ProdutoId == produto.ProdutoId);
        }

        //Limpar carrinho

        public void LimparCarrinho()
        {
            _itensCarrinho.Clear();
        }

        //Itens carrinho

        public IEnumerable<ItemCarrinho> ItensCarrinho
        {
            get { return _itensCarrinho; }
        }

        //Obter o valor total

        public decimal ObterValorTotal()
        {
            return _itensCarrinho.Sum(p => p.Produto.Preco*p.Quantidade);
        }
    }
}
