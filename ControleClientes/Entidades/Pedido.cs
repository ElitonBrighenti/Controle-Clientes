using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int ClienteId { get; set; }  // Chave estrangeira para Cliente
        public Cliente Cliente { get; set; }  // Navegação de relacionamento com Cliente
        public string Status { get; set; }
        public ICollection<Item> Itens { get; set; } = new List<Item>(); // Lista de itens do pedido

    }
}
