using ControleClientes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Repository
{
    public class ItemPedidoRepository
    {
        private readonly ApplicationDBContext _context;

        public ItemPedidoRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<ItemPedido> ReadAll()
        {
            return _context.ItensPedidos
                .Include(i => i.Pedido)
                //.Include(i => i.Produto)
                .ToList();
        }

        public void Create(ItemPedido itemPedido)
        {
            _context.ItensPedidos.Add(itemPedido);
            _context.SaveChanges();
        }

        public void Update(ItemPedido itemPedido)
        {
            ItemPedido itemExistente = GetById(itemPedido.Id);
            if (itemExistente != null)
            {
                itemExistente.PedidoId = itemPedido.PedidoId;
                itemExistente.ProdutoId = itemPedido.ProdutoId;
                itemExistente.Quantidade = itemPedido.Quantidade;
                itemExistente.PrecoUnitario = itemPedido.PrecoUnitario;
                _context.SaveChanges();
            }
        }

        public void Delete(ItemPedido itemPedido)
        {
            ItemPedido itemExistente = GetById(itemPedido.Id);
            if (itemExistente != null)
            {
                _context.ItensPedidos.Remove(itemExistente);
                _context.SaveChanges();
            }
        }

        public ItemPedido GetById(int id)
        {
            return _context.ItensPedidos
                .Include(i => i.Pedido)
                .Include(i => i.Produto)
                .FirstOrDefault(i => i.Id == id);
        }
    }

}
