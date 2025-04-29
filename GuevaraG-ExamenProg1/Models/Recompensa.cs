using System.ComponentModel.DataAnnotations;

namespace GuevaraG_ExamenProg1.Models
{
    public class Recompensa
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Nombre { get; set; }
        [DataType(DataType.Date), Required]
        public DateTime FechaInicio { get; set; }
        public int Puntos { get; set; }
        public string Tipo
        {
            get
            {
                return Puntos <=500 ? "SILVER" : "GOLD";
            }
        }

    }
}
