using ControleClientes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Repository
{
    public class PedidoRepository
    {
        private readonly ApplicationDBContext _context;

        public PedidoRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Pedido> ReadAll()
        {
            return _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Itens)
                .ThenInclude(i => i.Produto)
                .ToList();
        }

        public void Create(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        public void Update(Pedido pedido)
        {
            Pedido pedidoExistente = GetById(pedido.Id);
            if (pedidoExistente != null)
            {
                pedidoExistente.Data = pedido.Data;
                pedidoExistente.Status = pedido.Status;
                pedidoExistente.ClienteId = pedido.ClienteId;
                pedidoExistente.Itens = pedido.Itens;
                _context.SaveChanges();
            }
        }

        //METODO DELETAR ANTIGO
        //public void Delete(Pedido pedido)
        //{
        //    Pedido pedidoExistente = GetById(pedido.Id);
        //    if (pedidoExistente != null)
        //    {
        //        _context.Pedidos.Remove(pedidoExistente);
        //        _context.SaveChanges();
        //    }
        //}
        // PedidoRepository.cs
        public void Delete(int pedidoId)
        {
            var pedido = _context.Pedidos
                .Include(p => p.Itens) // Carregar itens associados
                .FirstOrDefault(p => p.Id == pedidoId);

            if (pedido != null)
            {
                // Remover os itens diretamente, sem depender de ItensPedido
                foreach (var item in pedido.Itens.ToList())
                {
                    _context.ItensPedidos.Remove(item); // Remover itens
                }

                _context.Pedidos.Remove(pedido); // Remover o pedido
                _context.SaveChanges(); // Salvar alterações
            }
            else
            {
                throw new Exception("Pedido não encontrado.");
            }
        }





        public Pedido GetById(int id)
        {
            return _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Itens)
                .ThenInclude(i => i.Produto)
                .FirstOrDefault(p => p.Id == id);
        }
    }


}
