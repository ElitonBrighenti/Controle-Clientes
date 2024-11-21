﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class Item
    {
        public int Id { get; set; }
        public int PedidoId { get; set; } 
        public Pedido Pedido { get; set; } 
        public int ProdutoId { get; set; } 
        public Produto Produto { get; set; } 
        public int Quantidade { get; set; }
        public decimal PrecoUnitario { get; set; }
        public decimal Total { get; set; }
    }

}
