using ControleClientes.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleClientes
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Item> Itens { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;username=postgres;database=clientes;Password=2024");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relacionamento muitos-para-muitos entre Item e Produto
            modelBuilder.Entity<Item>()
                .HasMany(i => i.Produtos)
                .WithMany()
                .UsingEntity(j => j.ToTable("ItemProdutos")); // Define o nome da tabela de junção

            // Configurar chave composta para a tabela de junção, se necessário
            modelBuilder.Entity<Item>()
                .Navigation(i => i.Produtos)
                .AutoInclude(); // Opcional: Carregar produtos automaticamente ao buscar itens

            // Outras configurações de entidades
            base.OnModelCreating(modelBuilder);
        }



    }
}

