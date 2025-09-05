namespace GerenciadorLivrosBackend.Models
{
    public class Livro
    {
        public Int32 Id { get; set; }
        public String Titulo { get; set; }
        public String Autor { get; set; }
        public String Genero { get; set; }
        public Int32 Ano { get; set; }
    }
}
