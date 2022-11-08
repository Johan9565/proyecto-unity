using Microsoft.EntityFrameworkCore;
using WebApplication1.models;

namespace WebApplication1.data
{
    public class AplicationDbContent: DbContext
    {
        public AplicationDbContent(DbContextOptions<AplicationDbContent> options)
               : base(options) {  }

        DbSet<Personaje> personajes { get; set; }
        DbSet<Genero> generos { get; set; }
    }
}
