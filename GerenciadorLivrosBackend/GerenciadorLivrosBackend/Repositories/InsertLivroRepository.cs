using GerenciadorLivrosBackend.Models;
public class InsertLivroRepository : IInsertLivroRepository
{
    private readonly AppDbContext _context;

    public InsertLivroRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> InsertLivro(Livro livro)
    {
        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();
        return true;
    }
}
