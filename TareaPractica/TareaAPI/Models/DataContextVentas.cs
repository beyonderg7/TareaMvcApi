using System.Data.Entity;

namespace TareaAPI.Models
{
    public class DataContextVentas:DbContext
    {
        public DataContextVentas():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TareaAPI.Models.Venta> Ventas { get; set; }
    }
}