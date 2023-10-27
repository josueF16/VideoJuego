using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Email
    {
        [Key]
        public int IdEmail { get; set; }
        public string email { get; set; }
        public int IdUsuario { get; set; }

    }
}