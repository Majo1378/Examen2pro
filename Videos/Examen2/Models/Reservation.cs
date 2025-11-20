\
using System;
using System.ComponentModel.DataAnnotations;

namespace Examen2.Models
{
    public class Reservation
    {
        [Required(ErrorMessage = "El nombre del profesor es obligatorio.")]
        [MinLength(3, ErrorMessage = "El nombre debe tener al menos 3 caracteres.")]
        public string ProfessorName { get; set; }

        [Required(ErrorMessage = "El correo institucional es obligatorio.")]
        [EmailAddress(ErrorMessage = "Formato de correo inválido.")]
        [RegularExpression(@"^[\w.%+-]+@campus\.edu$", ErrorMessage = "El correo debe pertenecer al dominio @campus.edu")]
        public string InstitutionalEmail { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un laboratorio.")]
        public string Laboratory { get; set; }

        [Required(ErrorMessage = "La fecha de la reserva es obligatoria.")]
        [DataType(DataType.Date)]
        public DateTime ReservationDate { get; set; }

        [Required(ErrorMessage = "La hora de inicio es obligatoria.")]
        [DataType(DataType.Time)]
        public TimeSpan StartTime { get; set; }

        [Required(ErrorMessage = "La hora de fin es obligatoria.")]
        [DataType(DataType.Time)]
        public TimeSpan EndTime { get; set; }

        [Required(ErrorMessage = "El motivo es obligatorio.")]
        [MinLength(5, ErrorMessage = "El motivo debe tener al menos 5 caracteres.")]
        [MaxLength(200, ErrorMessage = "El motivo puede tener como máximo 200 caracteres.")]
        public string Reason { get; set; }

        [Required(ErrorMessage = "El código de reserva es obligatorio.")]
        [RegularExpression(@"^RES-\d{3}$", ErrorMessage = "El código debe tener el formato RES-###, por ejemplo RES-001")]
        public string ReservationCode { get; set; }
    }
}
