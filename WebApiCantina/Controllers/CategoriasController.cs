using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiCantina.Context;
using WebApiCantina.Models.Estoque;

namespace WebApiCantina.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoriasController : ControllerBase
    {
      private readonly ILogger<CategoriasController> _logger;
        private readonly AppDbContext _context;

        public CategoriasController(ILogger<CategoriasController> logger, AppDbContext context)
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
        public ActionResult<IEnumerable<Categoria>> Get()
        {
            return _context.Categorias.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Categoria> Get(int id)
        {
            var Categoria = _context.Categorias.Find(id);
            if (Categoria == null) return NotFound("Categoria não encontrado");
            return Categoria;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Categoria Categoria)
        {
            if (Categoria == null) return BadRequest();
            _context.Categorias.Add(Categoria);
            _context.SaveChanges();
            return Ok(Categoria);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Categoria Categoria)
        {
            if (Categoria == null) return BadRequest();
            var CategoriaExistente = _context.Categorias.Find(id);
            if (CategoriaExistente == null) return NotFound();
            _context.Categorias.Update(Categoria);
            _context.SaveChanges();
            return Ok(Categoria);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Categoria = _context.Categorias.Find(id);
            if (Categoria == null) return NotFound();
            _context.Categorias.Remove(Categoria);
            _context.SaveChanges();
            return Ok(Categoria);
        }
    }  
}