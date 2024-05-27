namespace BFF_Crud_Simples.Controllers.Usuarios
{
    // Criei esta classe somente para receber os valores que chegam para controller, pois a Entidade está com os atributos configurados com 'private set'
    public class UsuarioDto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Genero { get; set; }
        public string Nacionalidade { get; set; }
    }
}
