using Curso.Api.Bussines.Entities;

namespace Curso.Api.Bussines.Repositories
{
    public interface IUsuarioRepository
    {
        void Adicionar(Usuario usuario);
        void Commit();
        Usuario ObterUsuario(string login);
    }
}
