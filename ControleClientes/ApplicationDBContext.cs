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
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=localhost;username=postgres;database=clientes;Password=2024");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemPedido>()
                .HasOne(i => i.Pedido)
                .WithMany(p => p.Itens)
                .HasForeignKey(i => i.PedidoId);

            modelBuilder.Entity<ItemPedido>()
                .HasOne(i => i.Produto)
                .WithMany()
                .HasForeignKey(i => i.ProdutoId);

            //modelBuilder.Entity<ItemPedido>()
            //    .HasOne(p => p.Pedido)
            //    .WithMany(c => c.)
            //    .HasForeignKey(p => p.CidadeId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<ClienteEndereco>()
            //    .HasOne(p => p.Cidade)
            //    .WithMany(c => c.Enderecos)
            //    .HasForeignKey(p => p.CidadeId)
            //    .OnDelete(DeleteBehavior.Restrict);

        }
    }
}

