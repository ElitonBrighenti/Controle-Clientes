using ControleClientes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Repository
{
    public class ItemRepository
    {
        private readonly ApplicationDBContext _context;

        public ItemRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public void Create(Item item)
        {
            _context.Itens.Add(item);
            _context.SaveChanges();
        }

        public void Update(Item item)
        {
            _context.Itens.Update(item);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Itens.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _context.Itens.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
