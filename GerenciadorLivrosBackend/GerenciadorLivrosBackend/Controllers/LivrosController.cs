using Microsoft.AspNetCore.Mvc;
using GerenciadorLivrosBackend.DTOs;
using GerenciadorLivrosBackend.Models;
using GerenciadorLivrosBackend.Services;

namespace GerenciadorLivrosBackend.Controllers
{
    [ApiController]
    [Route("api/")]
    public class LivrosController : Controller
    {
        private readonly ApiResponseService _apiResponseService;
        public readonly IGetLivroRepository _getLivroRepository;
        public readonly IGetLivrosRepository _getLivrosRepository;
        public readonly IDeleteLivroRepository _deleteLivroRepository;
        public readonly IInsertLivroRepository _insertLivroRepository;
        public readonly IUpdateLivroRepository _updateLivroRepository;

        public LivrosController(IGetLivroRepository getLivroRepository, IGetLivrosRepository getLivrosRepository, IDeleteLivroRepository deleteLivroRepository, IInsertLivroRepository insertLivroRepository, IUpdateLivroRepository updateLivroRepository, ApiResponseService responseService)
        {
            _getLivroRepository = getLivroRepository;
            _getLivrosRepository = getLivrosRepository;
            _deleteLivroRepository = deleteLivroRepository;
            _insertLivroRepository = insertLivroRepository;
            _updateLivroRepository = updateLivroRepository;
            _apiResponseService = responseService;
        }

        [HttpGet]
        [Route("livros")]
        public async Task<IActionResult> GetLivros()
        {
            // busca todos os livros cadastrados
            var livros = await _getLivrosRepository.GetLivros();
            return Ok(_apiResponseService.ApiResponse(true, "Consulta Realizada!", livros));
        }

        [HttpGet]
        [Route("livros/{id}")]
        public async Task<IActionResult> GetLivro(int id)
        {
            // busca os livros individualmente 
            var livro = await _getLivroRepository.GetLivro(id);
            if (livro != null) return Ok(_apiResponseService.ApiResponse(true, "Consulta Realizada!", livro));
            return BadRequest(_apiResponseService.ApiResponse(false, "Erro Durante a Consulta"));
        }

        [HttpPost]
        [Route("livros")]
        public async Task<IActionResult> InsertLivro(LivroDTO livroDTO)
        {
            // cadastra um novo livro
            var livro = new Livro
            {
                Ano = livroDTO.Ano,
                Autor = livroDTO.Autor,
                Genero = livroDTO.Genero,
                Titulo = livroDTO.Titulo
            };
            var addLivro = await _insertLivroRepository.InsertLivro(livro);
            if(addLivro) return Ok(_apiResponseService.ApiResponse(true, "Livro Adicionado com Sucesso!"));
            return BadRequest(_apiResponseService.ApiResponse(false, "Erro ao Adicionar Livro"));
        }

        [HttpPut]
        [Route("livros/{id}")]
        public async Task<IActionResult> UpdateLivro(int id, LivroDTO livroDTO)
        {
            // atualiza os livros individualmente
            var livro = new Livro
            {
                Id = id,
                Ano = livroDTO.Ano,
                Autor = livroDTO.Autor,
                Genero = livroDTO.Genero,
                Titulo = livroDTO.Titulo
            };
            var addLivro = await _updateLivroRepository.UpdateLivro(livro);
            if (addLivro) return Ok(_apiResponseService.ApiResponse(true, "Livro Atualizado com Sucesso!"));
            return BadRequest(_apiResponseService.ApiResponse(false, "Erro ao Atualizar Livro"));
        }

        [HttpDelete]
        [Route("livros/{id}")]
        public async Task<IActionResult> DeleteLivro(int id)
        {
            // deleta os livros individualmente
            var deleteLivro = await _deleteLivroRepository.DeleteLivro(id);
            if (deleteLivro) return Ok(_apiResponseService.ApiResponse(true, "Livro Removido com Sucesso!"));
            return BadRequest(_apiResponseService.ApiResponse(false, "Erro ao Remover Livro"));
        }
    }
}
