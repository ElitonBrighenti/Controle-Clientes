using System.ComponentModel.DataAnnotations;

namespace ControleClientes.Entidades
{
    public class Cidade
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Uf { get; set; }
    }
}
