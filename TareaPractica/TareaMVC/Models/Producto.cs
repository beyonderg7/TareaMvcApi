using System.ComponentModel.DataAnnotations;

namespace TareaMVC.Models
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public decimal Precio { get; set; }

    }
}