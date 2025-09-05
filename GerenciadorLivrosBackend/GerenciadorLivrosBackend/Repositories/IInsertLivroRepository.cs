using GerenciadorLivrosBackend.Models;

public interface IInsertLivroRepository
{
    Task<bool> InsertLivro(Livro livro);
}