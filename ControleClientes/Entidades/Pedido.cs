using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Entidades
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        // Data do pedido
        public DateTime DataPedido { get; set; }

        // Chave estrangeira para Cliente
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }  // Relacionamento com Cliente

        // Status do pedido
        public string Status { get; set; }
        public ICollection<Item> Itens { get; set; } = new List<Item>(); // Relacionamento com os Itens do Pedido

    }
}
