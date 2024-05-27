using BFF_Crud_Simples.Controllers.Usuarios;
using System.ComponentModel.DataAnnotations.Schema;

namespace BFF_Crud_Simples.Model
{
    public class Usuario
    {
        public Usuario()
        {
            
        }

        public Usuario(int id, string nome, int idade, string genero, string nacionalidade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Genero = genero;
            Nacionalidade = nacionalidade;
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
