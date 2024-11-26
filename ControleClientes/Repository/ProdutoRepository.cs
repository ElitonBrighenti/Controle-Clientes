using ControleClientes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes.Repository
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
        public void Create(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }
        public void Update(Produto produto)
        {
            Produto produtoExistente = GetById(produto.Id);
            if (produtoExistente != null)
            {
                produtoExistente.Nome = produto.Nome;
                produtoExistente.Descricao = produto.Descricao;
                produtoExistente.Preco = produto.Preco;
                produtoExistente.QuantidadeEstoque = produto.QuantidadeEstoque;
                produtoExistente.Categoria = produto.Categoria;
                _context.SaveChanges();
            }
        }

        // Exclui um produto
        public void Delete(Produto produto)
        {
            Produto produtoExistente = GetById(produto.Id);
            if (produtoExistente != null)
            {
                _context.Remove(produtoExistente);
                _context.SaveChanges();
            }
        }

        public Produto GetById(int id) => _context.Produtos.FirstOrDefault(c => c.Id == id);

    }

}
