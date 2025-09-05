using GerenciadorLivrosBackend.Models;

public class UpdateLivroRepository : IUpdateLivroRepository
{
    private readonly AppDbContext _context;

    public UpdateLivroRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<bool> UpdateLivro(Livro livro)
    {
        // metodo para atualizar um livro existente

        var verifica = await _context.Livros.FindAsync(livro.Id);
        if (verifica == null) return false;
        verifica.Ano = livro.Ano;
        verifica.Autor = livro.Autor;
        verifica.Genero = livro.Genero;
        verifica.Titulo = livro.Titulo;

        await _context.SaveChangesAsync();
        return true;
    }
}

