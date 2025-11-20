using Microsoft.AspNetCore.Mvc;
using Examen2.Data;
using Examen2.Models;
using System;

namespace Examen2.Controllers
{
    public class ReservationsController : Controller
    {
        private readonly InMemoryReservationRepository _repo;

        public ReservationsController(InMemoryReservationRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            var list = _repo.GetAll();
            return View(list);
        }

        public IActionResult Create()
        {
            ViewBag.Labs = new[] { "Seleccione...", "Lab-01", "Lab-02", "Lab-03", "Lab-Redes", "Lab-IA" };
            return View(new Reservation { ReservationDate = DateTime.Today });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Reservation model)
        {
            ViewBag.Labs = new[] { "Seleccione...", "Lab-01", "Lab-02", "Lab-03", "Lab-Redes", "Lab-IA" };

            if (!ModelState.IsValid)
                return View(model);

            var (success, error) = _repo.Add(model);
            if (!success)
            {
                ModelState.AddModelError(string.Empty, error);
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
