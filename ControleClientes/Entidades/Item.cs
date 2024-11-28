using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Entidades
{
    public class Item
    {
        [Key]
        public int Id { get; set; }

        // Chave estrangeira para Pedido
        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }  // Relacionamento com Pedido

        // Relacionamento com os produtos
        public ICollection<Produto> Produtos { get; set; } = new List<Produto>();  // Produtos no Item do Pedido
        public ICollection<int> Quantidades { get; set; } = new List<int>(); // Quantidade dos produtos no item
    }
}
