using System.Collections.Generic;
using System.Threading.Tasks;
using GerenciadorLivrosBackend.Models;

public interface IGetLivrosRepository
{
    Task<IEnumerable<Livro>> GetLivros();
}