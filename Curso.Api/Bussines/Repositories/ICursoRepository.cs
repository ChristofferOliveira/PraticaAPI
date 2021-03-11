using Curso.Api.Bussines.Entities;
using System.Collections.Generic;

namespace Curso.Api.Infraestruture.Data.Repositories
{
    public interface ICursoRepository
    {
        void Adicionar(Cursos curso);
        void Commit();
        IList<Cursos> ObterPorUsuario(int codigoUsuario);
    }
}
