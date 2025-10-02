using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiCantina.Application.DTOs;
using WebApiCantina.Application.Services.Mapping;
using WebApiCantina.Data.Services.Repositories;
using WebApiCantina.Domain.Models.Estoque;
using WebApiCantina.Domain.Services.Interfaces;

namespace WebApiCantina.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly IProdutosRepository _repository;

        public ProdutosController(ILogger<ProdutosController> logger, IProdutosRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> Get()
        {
            var produtos = await _repository.GetAllIncludingAsync(p => p.CategoriaProduto);
            var resultado = produtos.Select(p => p.ToDto()).ToList();
            return Ok(resultado);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoDto>> GetbyId(int id)
        {
            var produto = await _repository.GetByIdAsync(id);

            if (produto == null)
            {
                return NotFound();
            }

            var produtoResponse = new ProdutoResponse
            {
                IdProduto = produto.IdProduto,
                NomeProduto = produto.NomeProduto,
                DescricaoProduto = produto.DescricaoProduto,
                NomeCategoria = produto.CategoriaProduto.NomeCategoria,  // Nome da categoria
                QuantidadeEstoque = produto.QuantidadeEstoque,
                PrecoVenda = produto.PrecoVenda,
                Imagem = produto.Imagem,
                DataCriacao = produto.DataCriacao
            };

            return Ok(produtoResponse);
        }

        [HttpGet("categoria/{id}")]
        public async Task<ActionResult<IEnumerable<ProdutoDto>>> GetPorCategoria(int id)
        {
            var produtos = await _repository.GetAllIncludingAsync(p => p.CategoriaProduto);

            var filtrados = produtos
                .Where(p => p.CategoriaProduto != null && p.CategoriaProduto.IdCategoria == id)
                .Select(p => p.ToDto())
                .ToList();

            if (!filtrados.Any()) return NotFound("Produtos não encontrados");

            return Ok(filtrados);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduto([FromBody] ProdutoRequest request)
        {
            // Mapeamento manual de ProdutoRequest para Produto
            var produto = new Produto
            {
                NomeProduto = request.NomeProduto,
                DescricaoProduto = request.DescricaoProduto,
                IdCategoria = request.IdCategoria,
                QuantidadeEstoque = request.QuantidadeEstoque,
                PrecoVenda = request.PrecoVenda,
                Imagem = request.Imagem,
                DataCriacao = new DateTime()
            };

            // Adiciona o produto ao contexto e salva no banco de dados
            await _repository.AddAsync(produto);
            

            // Mapeamento manual de Produto para ProdutoResponse
            var produtoResponse = new ProdutoResponse
            {
                IdProduto = produto.IdProduto,
                NomeProduto = produto.NomeProduto,
                DescricaoProduto = produto.DescricaoProduto,
                NomeCategoria = produto.CategoriaProduto.NomeCategoria, // Nome da categoria
                QuantidadeEstoque = produto.QuantidadeEstoque,
                PrecoVenda = produto.PrecoVenda,
                Imagem = produto.Imagem,
                DataCriacao = produto.DataCriacao
            };

            return CreatedAtAction(nameof(GetbyId), new { id = produto.IdProduto }, produtoResponse);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] Produto produto)
        {
            if (produto == null || id != produto.IdProduto)
                return BadRequest("Dados inválidos");

            var produtoExistente = await _repository.GetByIdAsync(id);
            if (produtoExistente == null)
                return NotFound("Produto não encontrado");

            produtoExistente.AtualizarCom(produto);

            await _repository.UpdateAsync(produtoExistente);
            return Ok(produtoExistente.ToDto());
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var produto = await _repository.GetByIdAsync(id);
            if (produto == null) return NotFound("Produto não encontrado");

            await _repository.DeleteAsync(produto);
            return Ok(produto.ToDto());
        }
    }
}
