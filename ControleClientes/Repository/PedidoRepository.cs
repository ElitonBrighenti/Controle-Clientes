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
            return _context.Pedidos.ToList();
        }
        public void Create(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            _context.SaveChanges();
        }

        //public Pedido GetById(int id)
        //{
        //    return _context.Pedidos
        //        .Include(p => p.Id)
        //        .ThenInclude(i => i.Produto)
        //        .FirstOrDefault(p => p.Id == id);
        //}

        public List<Pedido> GetAll()
        {
            return _context.Pedidos.ToList();
        }

        public void Update(Pedido pedido)
        {
            _context.Pedidos.Update(pedido);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            //var pedido = GetById(id);
            //if (pedido != null)
            //{
            //    _context.Pedidos.Remove(pedido);
            //    _context.SaveChanges();
            //}
        }
    }
}
