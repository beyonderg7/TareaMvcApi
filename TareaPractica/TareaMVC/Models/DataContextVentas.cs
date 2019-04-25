using System.Data.Entity;

namespace TareaMVC.Models
{
    public class DataContextVentas:DbContext
    {
        public DataContextVentas():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TareaMVC.Models.Venta> Ventas { get; set; }
    }
}