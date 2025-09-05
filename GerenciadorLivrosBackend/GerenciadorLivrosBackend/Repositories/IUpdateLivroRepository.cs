using GerenciadorLivrosBackend.Models;

public interface IUpdateLivroRepository
{
    Task<bool> UpdateLivro(Livro livro);
}