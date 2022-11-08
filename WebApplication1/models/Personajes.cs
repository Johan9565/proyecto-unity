using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.models
{
    public class Personaje
    {
        [Key]
        public int PkPersonaje { get; set; }
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Poder { get; set; }
        
        [ForeignKey("genero")]
        public Genero genero { get; set; }
        public int FkGenero { get; set; }
    }

}
