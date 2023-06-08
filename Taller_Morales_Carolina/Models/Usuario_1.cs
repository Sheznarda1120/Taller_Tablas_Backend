using System.ComponentModel.DataAnnotations;

namespace Taller_Morales_Carolina.Models
{
    public class Usuario_1
    {
        public int Id { get; set; }
        [Required]
        public string NombreUsuario { get; set; }
        [Required]
        public string Clave { get; set; }
        [Required]
        public string Estado { get; set; }

        public int GeneroId { get; set; }
        public Genero Genero { get; set; }

    }
}
