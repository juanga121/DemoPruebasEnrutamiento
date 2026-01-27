using DemoPruebasEnrutamiento.Application.Interface;
using DemoPruebasEnrutamiento.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoPruebaEnrutamiento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _service;

        public UsuariosController(IUsuarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
            => Ok(await _service.ObtenerTodos());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var usuario = await _service.ObtenerPorId(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> Post(Usuario usuario)
        {
            await _service.Crear(usuario);
            return Ok(usuario);
        }

        [HttpPut]
        public async Task<IActionResult> Put(Usuario usuario)
        {
            await _service.Actualizar(usuario);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Eliminar(id);
            return NoContent();
        }
    }
}
