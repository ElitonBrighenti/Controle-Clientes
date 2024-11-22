using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    // ProdutoRepository.cs
    public class ProdutoRepository
    {
        private readonly ApplicationDBContext _context;

        public ProdutoRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Produto> ReadAll()
        {
            return _context.Produtos.ToList();
        }

        // Adiciona um novo produto
        public void AdicionarProduto(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        // Exclui um produto
        public void ExcluirProduto(int produtoId)
        {
            var produto = _context.Produtos.Find(produtoId);
            if (produto != null)
            {
                _context.Produtos.Remove(produto);
                _context.SaveChanges();
            }
        }

        // Lista todos os produtos
        public List<Produto> ListarProdutos()
        {
            return _context.Produtos.ToList();
        }

        // Atualiza um produto
        public void AtualizarProduto(Produto produto)
        {
            _context.Produtos.Update(produto);
            _context.SaveChanges();
        }
    }

}
