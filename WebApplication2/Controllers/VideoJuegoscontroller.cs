using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VideoJuegoscontroller : ControllerBase
    {
        private readonly ILogger<VideoJuegoscontroller> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public VideoJuegoscontroller(
            ILogger<VideoJuegoscontroller> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] VideoJuegos videoJuegos)
        {
            _aplicacionContexto.VideoJuegos.Add(videoJuegos);
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuegos);
        }
        //READ: Obtener lista de estudiantes
        //[Route("")]
        [HttpGet]
        public IEnumerable<VideoJuegos> Get()
        {
            return _aplicacionContexto.VideoJuegos.ToList();
        }
        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] VideoJuegos videoJuegos)
        {
            _aplicacionContexto.VideoJuegos.Update(videoJuegos);
            _aplicacionContexto.SaveChanges();
            return Ok(videoJuegos);
        }
        //Delete: Eliminar estudiantes
       // [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int videoID)
        {
            _aplicacionContexto.VideoJuegos.Remove(
                _aplicacionContexto.VideoJuegos.ToList()
                .Where(x => x.IdVideoJuego == videoID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();

            return Ok(videoID);
        }
    }
}