using Microsoft.EntityFrameworkCore;
using GerenciadorLivrosBackend.Models;

public class GetLivrosRepository : IGetLivrosRepository
{
    private readonly AppDbContext _context;

    public GetLivrosRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Livro>> GetLivros()
    {
        return await _context.Livros.ToListAsync();
    }
}

