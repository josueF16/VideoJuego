using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class AplicacionContexto : DbContext
    {
        public AplicacionContexto
            (DbContextOptions<AplicacionContexto> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<VideoJuegos> VideoJuegos { get; set; }
        public DbSet<Email> Emails { get; set; }

    }
}
