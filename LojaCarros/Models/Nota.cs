using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    public class Nota
    {
        [Key]
        public int Id { get; set; }

        public int Numero { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataEmissao { get; set; }

        public string Garantia { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorVenda { get; set; }

        // Relacionamentos
        public int ClienteId { get; set; }
        public Cliente Comprador { get; set; }

        public int VendedorId { get; set; }
        public Vendedor Vendedor { get; set; }

        public int CarroId { get; set; }
        public Carro Carro { get; set; }
    }
}
