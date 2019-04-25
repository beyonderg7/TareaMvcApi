using System;
using System.ComponentModel.DataAnnotations;

namespace TareaMVC.Models
{
    public class Venta
    {
        

        [Key]
        public int VentaId { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public int ProductoId { get; set; }
        [Required]
        public int ClieteId { get; set; }

    }
}