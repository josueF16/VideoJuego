using Microsoft.AspNetCore.Mvc;
using WebApplication2.Context;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly ILogger<EmailController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public EmailController(
            ILogger<EmailController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear estudiantes
        //[Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Email email)
        {
            _aplicacionContexto.Emails.Add(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //READ: Obtener lista de estudiantes
       //[Route("")]
        [HttpGet]
        public IEnumerable<Email> Get()
        {
            return _aplicacionContexto.Emails.ToList();
        }
        //Update: Modificar estudiantes
        //[Route("/id")]
        [HttpPut]
        public IActionResult Put([FromBody] Email email)
        {
            _aplicacionContexto.Emails.Update(email);
            _aplicacionContexto.SaveChanges();
            return Ok(email);
        }
        //Delete: Eliminar estudiantes
        //[Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int emailID)
        {
            _aplicacionContexto.Emails.Remove(
                _aplicacionContexto.Emails.ToList()
                .Where(x => x.IdEmail == emailID)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();

            return Ok(emailID);
        }
    }
}