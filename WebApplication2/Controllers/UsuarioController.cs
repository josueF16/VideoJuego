using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UsuarioController(
            ILogger<UsuarioController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuarios.Add(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        //READ: Obtener lista de estudiantes
        [Route("")]
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            return _aplicacionContexto.Usuarios.ToList();
        }
        //Update: Modificar estudiantes
        [Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Usuario usuario)
        {
            _aplicacionContexto.Usuarios.Update(usuario);
            _aplicacionContexto.SaveChanges();
            return Ok(usuario);
        }
        //Delete: Eliminar estudiantes
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int usuarioID)
        {
            _aplicacionContexto.Usuarios.Remove(
                _aplicacionContexto.Usuarios.ToList()
                .Where(x => x.IdUsuario == usuarioID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();

            return Ok(usuarioID);
        }
    }
}