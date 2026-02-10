using DemoPruebasEnrutamiento.Application.Interface;
using DemoPruebasEnrutamiento.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DemoPruebaEnrutamiento.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController(IUsuarioService service) : Controller
    {
        private readonly IUsuarioService _service = service;

        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
            => Ok(await _service.ObtenerTodos());

        [HttpPost]
        public async Task<IActionResult> PostUsuarios(Usuario usuario)
        {
            await _service.Crear(usuario);
            return Ok(usuario);
        }
    }
}
