using GerenciadorLivrosBackend.Models;
public interface IDeleteLivroRepository
{
    Task<bool> DeleteLivro(int id);
}
