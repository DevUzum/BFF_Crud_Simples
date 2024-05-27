using BFF_Crud_Simples.Model;
using BFF_Crud_Simples.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BFF_Crud_Simples.Controllers.Usuarios
{
    // Controller multi tarefas, aqui é realizada a integração com o DTO, Entidade e Repositório.
    // Poderia ter colocado isso em uma Service ou Handler, mas preferi poupar esforço pois é um projeto com outro foco.
    [ApiController]
    [Route("api/cliente")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _cadastrarUsuarioRepository;

        public UsuarioController(IUsuarioRepository cadastrarUsuarioRepository)
        {
            _cadastrarUsuarioRepository = cadastrarUsuarioRepository;
        }

        [HttpPost("cadastrar")]
        public IActionResult CadastrarUsuario([FromBody]UsuarioDto usuario, CancellationToken cancellationToken)
        {
            var usuarioCadastrado = Usuario.Criar(usuario.Nome, usuario.Idade, usuario.Genero, usuario.Nacionalidade);

            _cadastrarUsuarioRepository.AddAsync(usuarioCadastrado, cancellationToken);

            return Created("", usuarioCadastrado);
        }

        [HttpPatch("alterar/{id}")]
        public IActionResult AlterarUsuario([FromRoute]int id, [FromBody]UsuarioDto usuario, CancellationToken cancellationToken)
        {
            var usuarioEncontrado = _cadastrarUsuarioRepository.ObterUsuarioPorId(id, cancellationToken);

            usuarioEncontrado.Alterar(usuario);

            _cadastrarUsuarioRepository.AlterAsync(usuarioEncontrado, cancellationToken);

            return NoContent();
        }

        [HttpDelete("remover/{id}")]
        public IActionResult RemoverUsuario([FromRoute]int id, CancellationToken cancellationToken)
        {
            var usuarioRemovido = _cadastrarUsuarioRepository.ObterUsuarioPorId(id, cancellationToken);

            _cadastrarUsuarioRepository.DeleteAsync(usuarioRemovido, cancellationToken);

            return Ok();
        }

        [HttpGet("obter/{id}")]
        public IActionResult ObterUsuario([FromRoute]int id, CancellationToken cancellationToken)
        {
            var usuarioEncontrado = _cadastrarUsuarioRepository.ObterUsuarioPorId(id, cancellationToken);

            return Ok(usuarioEncontrado);
        }
    }
}
