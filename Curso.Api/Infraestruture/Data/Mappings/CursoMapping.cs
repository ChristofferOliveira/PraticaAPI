using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Curso.Api.Bussines.Entities;

namespace Curso.Api.Infraestruture.Data.Mappings
{
    public class CursoMapping : IEntityTypeConfiguration<Cursos>
    {
        public void Configure(EntityTypeBuilder<Cursos> builder)
        {
            builder.ToTable("TB_Curso");
            builder.HasKey(p => p.Codigo);
            builder.Property(p => p.Codigo).ValueGeneratedOnAdd();
            builder.Property(p => p.Nome);
            builder.Property(p => p.Descricao);
            builder.HasOne(p => p.Usuario).WithMany().HasForeignKey(fk => fk.CodigoUsuario);
        }
    }
}
