using Curso.Api.Bussines.Entities;
using Curso.Api.Infraestruture.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Curso.Api.Infraestruture.Data
{
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CursoMapping());
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
    }
}
