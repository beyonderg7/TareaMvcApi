using System.ComponentModel.DataAnnotations;

namespace TareaAPI.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Correo { get; set; }

    }
}