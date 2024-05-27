using BFF_Crud_Simples.Model;
using Microsoft.EntityFrameworkCore;

namespace BFF_Crud_Simples.Infra.Context
{
    // Contexto do projeto, vinculando as minhas tabelas criadas manualmente sem uso de migration.
    public class CrudContext : DbContext
    {
        public CrudContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
