using System.Data.Entity;

namespace TareaAPI.Models
{
    public class DataContextClientes : DbContext
    {
        public DataContextClientes() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TareaAPI.Models.Cliente> Clientes { get; set; }
    }
}