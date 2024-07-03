using CRUD_CSHARP.Data.Map;
using CRUD_CSHARP.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_CSHARP.Data
{
    public class SistemasTarefasDBContext : DbContext
    {
        public SistemasTarefasDBContext(DbContextOptions<SistemasTarefasDBContext> options)
        
            : base(options)
        { 
        }
        
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());   

            base.OnModelCreating(modelBuilder);

        }


    }
}
