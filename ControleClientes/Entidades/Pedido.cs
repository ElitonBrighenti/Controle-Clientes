using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Entidades
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Pendente";
        public decimal Total { get; set; }
        public List<Item> Itens { get; set; } = new List<Item>();

    }
}
