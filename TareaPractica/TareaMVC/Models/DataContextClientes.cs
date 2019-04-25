using System.Data.Entity;

namespace TareaMVC.Models
{
    public class DataContextClientes : DbContext
    {
        public DataContextClientes() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TareaMVC.Models.Cliente> Clientes { get; set; }
    }
}