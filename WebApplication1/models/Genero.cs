using System.ComponentModel.DataAnnotations;

namespace WebApplication1.models
{
    public class Genero
    {
        [Key]
        public int PkGnero { get; set; }
        public string Nombre { get; set; }
    }
}
