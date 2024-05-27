using BFF_Crud_Simples.Controllers.Usuarios;
using System.ComponentModel.DataAnnotations.Schema;

namespace BFF_Crud_Simples.Model
{
    // Entidade simples, sem acesso direto as propriedades e acessando apenas por meio de construtor ou métodos.
    // O construtor vazio é por conta de um erro chato que ocorre, é possível burlar esse erro, porém fiquei com preguiça hahaha
    public class Usuario
    {
        public Usuario()
        {
            
        }

        public Usuario(string nome, int idade, string genero, string nacionalidade)
        {
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Nacionalidade = nacionalidade;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int Idade { get; private set; }
        public string Genero { get; private set; }
        public string Nacionalidade { get; private set; }

        public static Usuario Criar(string nome, int idade, string genero, string nacionalidade)
        {
            var usuario = new Usuario(nome, idade, genero, nacionalidade);

            return usuario;
        }

        public void Alterar(UsuarioDto usuario)
        {
            Nome = usuario.Nome;
            Idade = usuario.Idade;
            Genero = usuario.Genero;
            Nacionalidade = usuario.Nacionalidade;
        }
    }
}
