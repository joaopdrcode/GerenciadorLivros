using GerenciadorLivrosBackend.Models;

public interface IGetLivroRepository
{
    Task<Livro?>GetLivro(int id);
}