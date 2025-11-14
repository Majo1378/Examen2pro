using Microsoft.AspNetCore.Mvc;
using ProyectoInscripciones.Models;

public class InscripcionesController : Controller
{
    private static List<Inscripcion> _inscripciones = new();

    public IActionResult Crear()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Crear(Inscripcion inscripcion)
    {
        if (!ModelState.IsValid)
        {
            return View(inscripcion);
        }

        _inscripciones.Add(inscripcion);
        ViewBag.Mensaje = "¡Inscripción realizada con éxito!";

        return View();
    }

    public IActionResult Lista()
    {
        return View(_inscripciones);
    }
}