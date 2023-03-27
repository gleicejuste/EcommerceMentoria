using EM.Domain.Enums;
using System;

namespace EM.Domain.Entidades
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public DateTime DataPedido { get; set; }
        public Cliente Cliente { get; set; }
        public Guid ClienteId { get; set; }
        public EStatusPedido StatusPedido { get; set;}

        public Pedido() { }

        public Pedido(DateTime dataPedido, Cliente cliente, EStatusPedido statusPedido)
        {
            DataPedido = dataPedido;
            Cliente = cliente;
            StatusPedido = statusPedido;
        }
    }
}
