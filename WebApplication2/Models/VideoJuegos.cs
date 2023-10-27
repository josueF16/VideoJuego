using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace WebApplication2.Models
{
    public class VideoJuegos
    {
        [Key]
        public int IdVideoJuego { get; set; }
        public string Nombre { get; set; }
        public string TipoDePago { get; set; }
        public bool EsGrupal { get; set; }
        public string Tipo{ get; set; }
        public int IdUsuario { get; set; }
    }
}