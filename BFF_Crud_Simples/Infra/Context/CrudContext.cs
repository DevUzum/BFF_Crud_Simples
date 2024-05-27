using BFF_Crud_Simples.Model;
using Microsoft.EntityFrameworkCore;

namespace BFF_Crud_Simples.Infra.Context
{
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
