using System;
using System.Collections.Generic;
using System.Linq;
using Examen2.Models;

namespace Examen2.Data
{
    public class InMemoryReservationRepository
    {
        private readonly List<Reservation> _reservations = new();

        public IEnumerable<Reservation> GetAll()
            => _reservations.OrderBy(r => r.ReservationDate).ThenBy(r => r.StartTime);

        public (bool Success, string Error) Add(Reservation r)
        {
            // Código único (case-insensitive)
            if (_reservations.Any(x => string.Equals(x.ReservationCode, r.ReservationCode, StringComparison.OrdinalIgnoreCase)))
                return (false, "El código de reserva ya existe.");

            // Laboratorio válido
            var validLabs = new[] { "Lab-01", "Lab-02", "Lab-03", "Lab-Redes", "Lab-IA" };
            if (!validLabs.Contains(r.Laboratory))
                return (false, "Laboratorio inválido. Seleccione un laboratorio válido.");

            // Fecha no en pasado
            var today = DateTime.Today;
            if (r.ReservationDate.Date < today)
                return (false, "La fecha de la reserva no puede ser anterior a la fecha actual.");

            // Horas válidas
            if (r.EndTime <= r.StartTime)
                return (false, "La hora de fin debe ser mayor que la hora de inicio y la duración debe ser positiva.");

            // No duración cero
            if ((r.EndTime - r.StartTime) == TimeSpan.Zero)
                return (false, "La reserva debe tener una duración mayor a cero.");

            // Conflicto de solapamiento en mismo laboratorio y fecha
            var conflict = _reservations.Any(existing =>
                existing.Laboratory == r.Laboratory
                && existing.ReservationDate.Date == r.ReservationDate.Date
                && ((r.StartTime >= existing.StartTime && r.StartTime < existing.EndTime)
                    || (r.EndTime > existing.StartTime && r.EndTime <= existing.EndTime)
                    || (r.StartTime <= existing.StartTime && r.EndTime >= existing.EndTime))
            );

            if (conflict)
                return (false, "La reserva se solapa con otra existente en el mismo laboratorio.");

            _reservations.Add(r);
            return (true, string.Empty);
        }
    }
}
