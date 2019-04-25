using System.Data.Entity;

namespace TareaAPI.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TareaAPI.Models.Producto> Productoes { get; set; }
    }
}