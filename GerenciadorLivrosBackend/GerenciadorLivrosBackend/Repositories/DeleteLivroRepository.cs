
public class DeleteLivroRepository : IDeleteLivroRepository
{
    private readonly AppDbContext _context;

    public DeleteLivroRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> DeleteLivro(int id)
    {
        var livro = await _context.Livros.FindAsync(id);
        if (livro == null) return false;
        _context.Livros.Remove(livro);
        await _context.SaveChangesAsync();
        return true;
    }

}
