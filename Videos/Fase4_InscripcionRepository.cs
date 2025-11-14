// Data/InscripcionRepository.cs
using System.Collections.Generic;
using Practica3_Progra3_CASO2.Models;
using System.Linq;
namespace Practica3_Progra3_CASO2.Data
{
    public static class InscripcionRepository
    {
        private static List<Inscripcion> _inscripciones = new List<Inscripcion>();
        private static int _nextId = 1;
        public static void AgregarInscripcion(Inscripcion inscripcion)
        {
            inscripcion.Id = _nextId++;
            _inscripciones.Add(inscripcion);
        }
        public static List<Inscripcion> ObtenerInscripciones()
            => _inscripciones.ToList();
    }
}