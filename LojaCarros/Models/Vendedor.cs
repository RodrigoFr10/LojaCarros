using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }

        public string Nome { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        public string Matricula { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }

        // Método para calcular comissão
        public decimal CalcularComissao(decimal valorVenda)
        {
            return valorVenda * 0.05m; // Exemplo: 5% de comissão
        }
    }
}
