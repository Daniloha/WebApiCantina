using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApiCantina.Context;
using WebApiCantina.Models.Estoque;

namespace WebApiCantina.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly ILogger<ProdutosController> _logger;
        private readonly AppDbContext _context;

        public ProdutosController(ILogger<ProdutosController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

         /* Tipos de retornos (Action/ActionResult/IActionResult):
         * Action - Retorna um tipo simples (ActionResult).
         * ActionResult - Retorna um tipo complexo (ActionResult).
         * IActionResult - Retorna um tipo complexo (IActionResult).
         */

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            return _context.Produtos.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Produto> Get(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null) return NotFound("Produto não encontrado");
            return produto;
        }

        [HttpGet("categoria/{id}")]
        public ActionResult<IEnumerable<Produto>> GetPorCategoria(int id)
        {
            var produtos = _context.Produtos.Where(p => p.CategoriaProduto.IdCategoria == id).ToList();
            if (produtos == null) return NotFound("Produtos não encontrados");
            return produtos;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            if (produto == null) return BadRequest();
            _context.Produtos.Add(produto);
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Produto produto)
        {
            if (produto == null) return BadRequest();
            var produtoExistente = _context.Produtos.Find(id);
            if (produtoExistente == null) return NotFound();
            _context.Produtos.Update(produto);
            _context.SaveChanges();
            return Ok(produto);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null) return NotFound();
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return Ok(produto);
        }
    }  
}