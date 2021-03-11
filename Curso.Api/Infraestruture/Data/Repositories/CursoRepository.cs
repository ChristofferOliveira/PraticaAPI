using Curso.Api.Bussines.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Curso.Api.Infraestruture.Data.Repositories
{
    public class CursoRepository : ICursoRepository
    {
        private readonly CursoDbContext _contexto;

        public CursoRepository(CursoDbContext contexto)
        {
            _contexto = contexto;
        }

        public void Adicionar(Cursos curso)
        {
            _contexto.Cursos.Add(curso);
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public IList<Cursos> ObterPorUsuario(int codigoUsuario)
        {
            return _contexto.Cursos.Include(i => i.Usuario).Where(w => w.CodigoUsuario == codigoUsuario).ToList(); 
        }
    }
}
