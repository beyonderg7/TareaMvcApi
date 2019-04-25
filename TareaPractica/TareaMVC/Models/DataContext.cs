using System.Data.Entity;

namespace TareaMVC.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TareaMVC.Models.Producto> Productoes { get; set; }

    }
}