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
        public DateTime Data { get; set; }
        public string Status { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public ICollection<ItemPedido> Itens { get; set; }
    }
}
