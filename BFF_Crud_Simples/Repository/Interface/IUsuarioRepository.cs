using BFF_Crud_Simples.Model;

namespace BFF_Crud_Simples.Repository.Interface
{
    public interface IUsuarioRepository
    {
        void AddAsync(Usuario usuario, CancellationToken cancellationToken);
        void AlterAsync(Usuario usuario, CancellationToken cancellationToken);
        void DeleteAsync(Usuario usuario, CancellationToken cancellationToken);
        Usuario? ObterUsuarioPorId(int id, CancellationToken cancellationToken);
    }
}
