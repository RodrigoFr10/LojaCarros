using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LojaCarros.Models
{
    public class Carro
    {
        [Key]
        public int Id { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public string Chassi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }
    }
}
