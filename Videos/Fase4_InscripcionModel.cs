// Models/Inscripcion.cs
using System;
using System.ComponentModel.DataAnnotations;
namespace Practica3_Progra3_CASO2.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        [Required, MinLength(2)]
        public string Nombre { get; set; }
        [Required, MinLength(2)]
        public string Apellidos { get; set; }
        [Required, EmailAddress]
        public string Correo { get; set; }
        [Required, RegularExpression(@"^\d{9,}$")]
        public string Telefono { get; set; }
        [Required]
        public string Taller { get; set; }
        [Required]
        public string NivelExperiencia { get; set; }
        [Required, DataType(DataType.Date)]
        public DateTime FechaTaller { get; set; }
        [Range(typeof(bool), "true", "true")]
        public bool AceptaTerminos { get; set; }
    }
}