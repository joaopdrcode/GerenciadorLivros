using GerenciadorLivrosBackend.Models;

public class GetLivroRepository : IGetLivroRepository
{
    private readonly AppDbContext _context;

    public GetLivroRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Livro?> GetLivro(int id)
    {
        // metodo para buscar livros individualmente

        return await _context.Livros.FindAsync(id);
    }
}

