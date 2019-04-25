using System.ComponentModel.DataAnnotations;

namespace TareaMVC.Models
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