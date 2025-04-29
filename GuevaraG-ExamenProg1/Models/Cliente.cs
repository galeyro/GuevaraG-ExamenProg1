using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuevaraG_ExamenProg1.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Nombre es requerido.")]
        [MaxLength(50)]
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
        public bool Descuento { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime FechaNacimiento { get; set; }
        public int RecompensasPuntos { get; set; }
        [ForeignKey("RecompensasPuntos")]
        public Recompensa? Recompensa { get; set; }
        public ICollection<Reserva> Reservas { get; set; }

    }
}
