using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Taller_Morales_Carolina.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string NombreUsuario { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string Clave { get; set; }
        [Required]
        public string Estado { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
