using BFF_Crud_Simples.Infra.Context;
using BFF_Crud_Simples.Model;
using BFF_Crud_Simples.Repository.Interface;

namespace BFF_Crud_Simples.Repository
{
    // Aqui a gente chama o Contexto para atualizar diretamente usando os comandos dele.
    public class UsuarioRepository : IUsuarioRepository
    {
        private CrudContext _crudContext;

        public UsuarioRepository(CrudContext crudContext)
        {
            _crudContext = crudContext;
        }

        public void AddAsync(Usuario usuario, CancellationToken cancellationToken)
        {
            _crudContext.Usuarios.Add(usuario);
            _crudContext.SaveChanges();
        }

        public void AlterAsync(Usuario usuario, CancellationToken cancellationToken)
        {
            _crudContext.Usuarios.Update(usuario);
            _crudContext.SaveChanges();
        }

        public void DeleteAsync(Usuario usuario, CancellationToken cancellationToken)
        {
            _crudContext.Usuarios.Remove(usuario);
            _crudContext.SaveChanges();
        }

        public Usuario ObterUsuarioPorId(int id, CancellationToken cancellationToken)
        {
            return _crudContext.Usuarios?
                .Where(x => x.Id == id)
                .ToList()
                .FirstOrDefault();
        }
    }
}
