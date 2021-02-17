using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EscuelaSystem.Data.Interfaces;
using EscuelaSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EscuelaSystem.Web.Pages
{
    public class EditarMaestroModel : PageModel
    {
        private readonly IMaestroRepository _maestroRepository;

        public EditarMaestroModel(IMaestroRepository MaestroRepository)
        {
            _maestroRepository = MaestroRepository;
        }

        [BindProperty]
        public Maestro Maestro { get; set; }
        public IActionResult OnGet(int id)
        {
            Maestro = _maestroRepository.GetbyId(id);
            if (Maestro == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var MaestroToUpdate = _maestroRepository.GetbyId(id);
            if (MaestroToUpdate == null)
                return NotFound();

            MaestroToUpdate.Carnet = Maestro.Carnet;
            MaestroToUpdate.Docente = Maestro.Docente;
            MaestroToUpdate.Activo = Maestro.Activo;

            _maestroRepository.Update(MaestroToUpdate);

            return RedirectToPage("./Maestros");
        }
    }
}
