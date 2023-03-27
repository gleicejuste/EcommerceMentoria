using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EM.Domain.Entidades
{
    public  class PedidoProduto
    {
        Produto Produto { get; set; }
        Pedido Pedido { get; set; }
        int Quantidade { get; set; }    

        public PedidoProduto() { }

        public PedidoProduto(
            Produto produto,
            Pedido pedido,
            int quantidade) 
        {
            Produto = produto; 
            Pedido = pedido; 
            Quantidade = quantidade;
        }


    }
}
