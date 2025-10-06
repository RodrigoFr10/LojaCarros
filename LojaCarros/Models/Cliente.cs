using System;
using System.ComponentModel.DataAnnotations;

namespace LojaCarros.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNasc { get; set; }

        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Cpf { get; set; }
    }
}
