using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuevaraG_ExamenProg1.Models
{
    public class Reserva
    {
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime FechaEntrada { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime FechaSalida { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal ValorPagar { get; set; }
        public string InfoCliente { get; set; }
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }

    }
}
